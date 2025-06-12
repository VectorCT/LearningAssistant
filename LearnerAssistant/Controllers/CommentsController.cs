using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentsController : ControllerBase
{
  private readonly ICommentService _commentService;

  public CommentsController(ICommentService commentService)
  {
    _commentService = commentService;
  }

  //[Authorize(Roles = "Student")]
  [HttpPost]
  public async Task<IActionResult> PostComment([FromBody] CommentDto dto)
  {
    //var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
    //if (userId == null) return Unauthorized();
    var userId = "2c49a5bb-bef5-47ef-8676-bc53baad9a29"; // For testing purposes, replace with actual user ID retrieval logic

    var comment = await _commentService.AddCommentAsync(dto.ForumId, userId, dto.CommentText, dto.ParentCommentId);
    return Ok(comment);
  }

  [HttpGet("{forumId}")]
  public async Task<IActionResult> GetComments(Guid forumId)
  {
    var comments = await _commentService.GetCommentsByForumAsync(forumId);
    return Ok(comments);
  }

  [Authorize(Roles = "Student")]
  [HttpPost("{commentId}/react")]
  public async Task<IActionResult> ReactToComment(Guid commentId, [FromBody] ReactionDto dto)
  {
    var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
    if (userId == null) return Unauthorized();

    var reaction = await _commentService.ReactToCommentAsync(commentId, userId, dto.Upvote, dto.Like);
    return Ok(reaction);
  }
}