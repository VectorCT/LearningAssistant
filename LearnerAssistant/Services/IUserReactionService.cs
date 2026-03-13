using DataAccessLayer.Models;

namespace LearnerAssistant.Services;

public interface IUserReactionService
{
  Task<UserReaction> AddOrUpdateReactionAsync(UserReaction reaction);
  Task<UserReaction?> GetReactionAsync(string userId, Guid commentId);
  Task<bool> RemoveReactionAsync(Guid id);
}
