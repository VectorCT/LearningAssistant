
namespace DataAccessLayer.Models;

public class UserReaction
{
  public Guid Id { get; set; }
  public string UserId { get; set; } = string.Empty;
  public ApplicationUser User { get; set; } = null!;
  public Guid CommentId { get; set; }
  public Comment? Comment { get; set; }
  public bool Upvote { get; set; }
  public bool Like { get; set; }
}
