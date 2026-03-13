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
    return await _context.Comments
      .AsNoTracking()
      .Where(c => c.ForumId == forumId && c.ParentCommentId == null)
      .Include(c => c.User)
      .Include(c => c.Replies)
      .ThenInclude(r => r.User)
      .Include(c => c.UserReactions)
      .ToListAsync();
  }

  public async Task<Comment?> GetByIdAsync(Guid id)
  {
    return await _context.Comments
      .AsNoTracking()
      .Include(c => c.User)
      .Include(c => c.Replies)
      .ThenInclude(r => r.User)
      .Include(c => c.UserReactions)
      .FirstOrDefaultAsync(c => c.Id == id);
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
