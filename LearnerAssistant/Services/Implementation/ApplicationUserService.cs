using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;

namespace LearnerAssistant.Services.Implementation;

public class ApplicationUserService : IApplicationUserService
{
  private readonly UserManager<ApplicationUser> _userManager;

  public ApplicationUserService(UserManager<ApplicationUser> userManager)
  {
    _userManager = userManager;
  }

  public async Task<ApplicationUser?> GetUserByIdAsync(string userId)
  {
    return await _userManager.FindByIdAsync(userId);
  }

  public async Task<bool> IsInRoleAsync(ApplicationUser user, string role)
  {
    return await _userManager.IsInRoleAsync(user, role);
  }

  public async Task AddUserToRoleAsync(ApplicationUser user, string role)
  {
    await _userManager.AddToRoleAsync(user, role);
  }

  public async Task RemoveUserFromRoleAsync(ApplicationUser user, string role)
  {
    await _userManager.RemoveFromRoleAsync(user, role);
  }
}
