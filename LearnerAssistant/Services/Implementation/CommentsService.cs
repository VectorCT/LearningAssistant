
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;
public class CommentService : ICommentService
{
  private readonly ApplicationDbContext _context;
  private readonly UserManager<ApplicationUser> _userManager;

  public CommentService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
  {
    _context = context;
    _userManager = userManager;
  }

  public async Task<Comment> AddCommentAsync(Guid forumId, string userId, string commentText, Guid? parentCommentId = null)
  {
    var user = await _userManager.FindByIdAsync(userId);
    //if (user == null || !await _userManager.IsInRoleAsync(user, "Student"))
    //  throw new UnauthorizedAccessException("Only students can comment.");

    var comment = new Comment
    {
      ForumId = forumId,
      UserId = userId,
      CommentText = commentText,
      ParentCommentId = parentCommentId,
      CreatedAt = DateTime.UtcNow
    };
    _context.Comments.Add(comment);
    await _context.SaveChangesAsync();
    return comment;
  }

  public async Task<Comment?> GetCommentAsync(Guid commentId)
  {
    return await _context.Comments
        .Include(c => c.User)
        .Include(c => c.Replies)
        .Include(c => c.UserReactions)
        .FirstOrDefaultAsync(c => c.Id == commentId);
  }

  public async Task<IEnumerable<Comment>> GetCommentsByForumAsync(Guid forumId)
  {
    return await _context.Comments
        .Where(c => c.ForumId == forumId && c.ParentCommentId == null)
        .Include(c => c.User)
        .Include(c => c.Replies)
        .Include(c => c.UserReactions)
        .ToListAsync();
  }

  public async Task<UserReaction> ReactToCommentAsync(Guid commentId, string userId, bool upvote, bool like)
  {
    var user = await _userManager.FindByIdAsync(userId);
    if (user == null || !await _userManager.IsInRoleAsync(user, "Student"))
      throw new UnauthorizedAccessException("Only students can react.");

    var existing = await _context.UserReactions
        .FirstOrDefaultAsync(r => r.CommentId == commentId && r.UserId == userId);

    if (existing != null)
    {
      existing.Upvote = upvote;
      existing.Like = like;
    }
    else
    {
      existing = new UserReaction
      {
        CommentId = commentId,
        UserId = userId,
        Upvote = upvote,
        Like = like
      };
      _context.UserReactions.Add(existing);
    }
    await _context.SaveChangesAsync();
    return existing;
  }

  public async Task<IEnumerable<UserReaction>> GetReactionsByCommentAsync(Guid commentId)
  {
    return await _context.UserReactions
        .Where(r => r.CommentId == commentId)
        .Include(r => r.User)
        .ToListAsync();
  }
}
