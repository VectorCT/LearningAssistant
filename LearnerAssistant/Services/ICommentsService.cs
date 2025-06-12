using DataAccessLayer.Models;

namespace LearnerAssistant.Services;
public interface ICommentService
{
  Task<Comment> AddCommentAsync(Guid forumId, string userId, string commentText, Guid? parentCommentId = null);
  Task<Comment?> GetCommentAsync(Guid commentId);
  Task<IEnumerable<Comment>> GetCommentsByForumAsync(Guid forumId);
  Task<UserReaction> ReactToCommentAsync(Guid commentId, string userId, bool upvote, bool like);
  Task<IEnumerable<UserReaction>> GetReactionsByCommentAsync(Guid commentId);
}
