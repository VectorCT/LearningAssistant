using DataAccessLayer.Models;

namespace LearnerAssistant.Services;

public interface ICommentService
{
  Task<Comment> CreateCommentAsync(Comment comment);
  Task<List<Comment>> GetCommentsByForumAsync(Guid forumId);
  Task<Comment?> GetByIdAsync(Guid id);
  Task<bool> UpdateCommentAsync(Comment comment);
  Task<bool> DeleteCommentAsync(Guid id);
}
