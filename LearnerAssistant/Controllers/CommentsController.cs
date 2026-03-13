using System;
using System.Linq;
using System.Collections.Generic;
using DataAccessLayer.Models;
using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers;

[ApiController]
[Route("api/Forums/{forumId:guid}/comments")]
public class CommentsController(ICommentService commentService, IUserReactionService reactionService) : ControllerBase
{
  private readonly ICommentService _commentService = commentService;
  private readonly IUserReactionService _reactionService = reactionService;

  private static CommentDto MapComment(Comment c)
  {
    if (c == null) return null!;

    return new CommentDto
    {
      Id = c.Id,
      ForumId = c.ForumId,
      UserId = c.UserId,
      UserName = c.User != null ? $"{c.User.Name} {c.User.Surname}".Trim() : string.Empty,
      CommentText = c.CommentText,
      ParentCommentId = c.ParentCommentId,
      Replies = c.Replies?.Select(r => MapComment(r)).ToList() ?? new List<CommentDto>(),
      UserReactions = c.UserReactions?.Select(r => new UserReactionDto { Id = r.Id, UserId = r.UserId, Upvote = r.Upvote, Like = r.Like }).ToList() ?? new List<UserReactionDto>(),
      Upvotes = c.Upvotes,
      Likes = c.Likes,
      CreatedAt = c.CreatedAt,
    };
  }

  [HttpGet]
  public async Task<IActionResult> GetByForum(Guid forumId)
  {
    var comments = await _commentService.GetCommentsByForumAsync(forumId);
    var dtos = comments.Select(MapComment).ToList();
    return Ok(dtos);
  }

  [HttpGet("{id:guid}")]
  public async Task<IActionResult> GetById(Guid forumId, Guid id)
  {
    var comment = await _commentService.GetByIdAsync(id);
    if (comment == null || comment.ForumId != forumId) return NotFound();
    return Ok(MapComment(comment));
  }

  [HttpPost]
  public async Task<IActionResult> Create(Guid forumId, [FromBody] Comment comment)
  {
    comment.ForumId = forumId;
    var created = await _commentService.CreateCommentAsync(comment);
    return CreatedAtAction(nameof(GetById), new { forumId = forumId, id = created.Id }, MapComment(created));
  }

  [HttpPut("{id:guid}")]
  public async Task<IActionResult> Update(Guid forumId, Guid id, [FromBody] Comment comment)
  {
    if (id != comment.Id) return BadRequest();
    if (comment.ForumId != forumId) return BadRequest();

    var ok = await _commentService.UpdateCommentAsync(comment);
    return ok ? NoContent() : NotFound();
  }

  [HttpDelete("{id:guid}")]
  public async Task<IActionResult> Delete(Guid forumId, Guid id)
  {
    var existing = await _commentService.GetByIdAsync(id);
    if (existing == null || existing.ForumId != forumId) return NotFound();

    var ok = await _commentService.DeleteCommentAsync(id);
    return ok ? NoContent() : NotFound();
  }

  // Reactions endpoints
  [HttpPost("{commentId:guid}/reactions")]
  public async Task<IActionResult> AddOrUpdateReaction(Guid forumId, Guid commentId, [FromBody] UserReaction reaction)
  {
    if (reaction.CommentId != Guid.Empty && reaction.CommentId != commentId) return BadRequest();
    reaction.CommentId = commentId;

    var created = await _reactionService.AddOrUpdateReactionAsync(reaction);
    var dto = created == null ? null : new UserReactionDto { Id = created.Id, UserId = created.UserId, Upvote = created.Upvote, Like = created.Like };
    return Ok(dto);
  }

  [HttpGet("{commentId:guid}/reactions/{userId}")]
  public async Task<IActionResult> GetReaction(Guid forumId, Guid commentId, string userId)
  {
    var r = await _reactionService.GetReactionAsync(userId, commentId);
    return r == null ? NotFound() : Ok(new UserReactionDto { Id = r.Id, UserId = r.UserId, Upvote = r.Upvote, Like = r.Like });
  }

  [HttpDelete("{commentId:guid}/reactions/{reactionId:guid}")]
  public async Task<IActionResult> RemoveReaction(Guid forumId, Guid commentId, Guid reactionId)
  {
    var ok = await _reactionService.RemoveReactionAsync(reactionId);
    return ok ? NoContent() : NotFound();
  }
}
