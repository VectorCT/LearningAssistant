using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class CommentService : ICommentService
{
  private readonly ApplicationDbContext _context;

  public CommentService(ApplicationDbContext context)
  {
    _context = context;
  }

  public async Task<Comment> CreateCommentAsync(Comment comment)
  {
    comment.Id = Guid.NewGuid();
    comment.CreatedAt = DateTime.Now;
    _context.Comments.Add(comment);
    await _context.SaveChangesAsync();
    return comment;
  }

  public async Task<List<Comment>> GetCommentsByForumAsync(Guid forumId)
  {
    // Load all comments and users for the forum in single queries
    var comments = await _context.Comments
      .AsNoTracking()
      .Where(c => c.ForumId == forumId)
      .ToListAsync();

    var commentIds = comments.Select(c => c.Id).ToList();

    var users = await _context.Users
      .AsNoTracking()
      .Where(u => comments.Select(c => c.UserId).Contains(u.Id))
      .ToListAsync();

    var reactions = await _context.UserReactions
      .AsNoTracking()
      .Where(r => commentIds.Contains(r.CommentId))
      .ToListAsync();

    // Map in memory
    var userDict = users.ToDictionary(u => u.Id);
    var reactionDict = reactions.GroupBy(r => r.CommentId).ToDictionary(g => g.Key, g => g.ToList());

    foreach (var comment in comments)
    {
      if (userDict.TryGetValue(comment.UserId, out var user))
        comment.User = user;

      if (reactionDict.TryGetValue(comment.Id, out var commentReactions))
        comment.UserReactions = commentReactions;

      comment.Replies = comments.Where(c => c.ParentCommentId == comment.Id).ToList();
    }

    return comments.Where(c => c.ParentCommentId == null).ToList();
  }

  public async Task<Comment?> GetByIdAsync(Guid id)
  {
    var comment = await _context.Comments
      .AsNoTracking()
      .FirstOrDefaultAsync(c => c.Id == id);

    if (comment == null) return null;

    // Load related data efficiently
    var replies = await _context.Comments
      .AsNoTracking()
      .Where(c => c.ParentCommentId == id)
      .ToListAsync();

    var userIds = replies.Select(r => r.UserId).Append(comment.UserId).Distinct().ToList();
    var users = await _context.Users
      .AsNoTracking()
      .Where(u => userIds.Contains(u.Id))
      .ToDictionaryAsync(u => u.Id);

    var reactions = await _context.UserReactions
      .AsNoTracking()
      .Where(r => r.CommentId == id)
      .ToListAsync();

    // Map in memory
    if (users.TryGetValue(comment.UserId, out var user))
      comment.User = user;

    comment.UserReactions = reactions;

    foreach (var reply in replies)
    {
      if (users.TryGetValue(reply.UserId, out var replyUser))
        reply.User = replyUser;
    }
    comment.Replies = replies;

    return comment;
  }

  public async Task<bool> UpdateCommentAsync(Comment comment)
  {
    var existing = await _context.Comments.FindAsync(comment.Id);
    if (existing == null) return false;

    existing.CommentText = comment.CommentText;
    existing.ParentCommentId = comment.ParentCommentId;

    _context.Comments.Update(existing);
    await _context.SaveChangesAsync();
    return true;
  }

  public async Task<bool> DeleteCommentAsync(Guid id)
  {
    var existing = await _context.Comments.FindAsync(id);
    if (existing == null) return false;

    _context.Comments.Remove(existing);
    await _context.SaveChangesAsync();
    return true;
  }
}
