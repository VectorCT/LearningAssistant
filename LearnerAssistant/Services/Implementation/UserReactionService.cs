using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class UserReactionService : IUserReactionService
{
  private readonly ApplicationDbContext _context;

  public UserReactionService(ApplicationDbContext context)
  {
    _context = context;
  }

  public async Task<UserReaction> AddOrUpdateReactionAsync(UserReaction reaction)
  {
    var existing = await _context.UserReactions
      .FirstOrDefaultAsync(r => r.UserId == reaction.UserId && r.CommentId == reaction.CommentId);

    if (existing == null)
    {
      reaction.Id = Guid.NewGuid();
      _context.UserReactions.Add(reaction);
    }
    else
    {
      existing.Upvote = reaction.Upvote;
      existing.Like = reaction.Like;
    }

    // persist reaction changes
    await _context.SaveChangesAsync();

    // update counts on comment
    var comment = await _context.Comments
      .Include(c => c.UserReactions)
      .FirstOrDefaultAsync(c => c.Id == reaction.CommentId);

    if (comment != null)
    {
      comment.Upvotes = comment.UserReactions.Count(r => r.Upvote);
      comment.Likes = comment.UserReactions.Count(r => r.Like);
      await _context.SaveChangesAsync();
    }

    return existing ?? reaction;
  }

  public async Task<UserReaction?> GetReactionAsync(string userId, Guid commentId)
  {
    return await _context.UserReactions
      .AsNoTracking()
      .FirstOrDefaultAsync(r => r.UserId == userId && r.CommentId == commentId);
  }

  public async Task<bool> RemoveReactionAsync(Guid id)
  {
    var existing = await _context.UserReactions.FindAsync(id);
    if (existing == null) return false;

    var commentId = existing.CommentId;
    _context.UserReactions.Remove(existing);
    await _context.SaveChangesAsync();

    var comment = await _context.Comments
      .Include(c => c.UserReactions)
      .FirstOrDefaultAsync(c => c.Id == commentId);

    if (comment != null)
    {
      comment.Upvotes = comment.UserReactions.Count(r => r.Upvote);
      comment.Likes = comment.UserReactions.Count(r => r.Like);
      await _context.SaveChangesAsync();
    }

    return true;
  }
}
