using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Models
{
  public class ApplicationUser : IdentityUser
  {
    public bool IsAccountDisabled { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public List<Comment> Comments { get; set; } = [];
    public List<UserReaction> UserReactions { get; set; } = [];

  }
}
