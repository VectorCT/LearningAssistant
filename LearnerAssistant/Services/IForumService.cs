using LearnerAssistant.Models;
using DataAccessLayer.Models;

namespace LearnerAssistant.Services;
public interface IForumService
{
  Task<Forum> CreateForumAsync(ForumDto forumDto, IFormFile? screenshot);
  Task<List<ForumDto>> GetAllForumsAsync();
  Task<ForumDto?> GetForumByIdAsync(Guid id);
  Task<bool> UpdateForumAsync(Forum forumDto, IFormFile? screenshot);
  Task<bool> DeleteForumAsync(Guid id);
}

