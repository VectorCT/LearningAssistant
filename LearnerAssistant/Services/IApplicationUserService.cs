using DataAccessLayer.Models;

namespace LearnerAssistant.Services;

public interface IApplicationUserService
{
  Task<ApplicationUser?> GetUserByIdAsync(string userId);
  Task<bool> IsInRoleAsync(ApplicationUser user, string role);
  Task AddUserToRoleAsync(ApplicationUser user, string role);
  Task RemoveUserFromRoleAsync(ApplicationUser user, string role);
}
