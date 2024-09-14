
namespace DataAccessLayer.Models;

public class UserReaction
{
  public int UserId { get; set; }
  public ApplicationUser User { get; set; } = null!;
  public int CommentId { get; set; }
  public Comment? Comment { get; set; }
  public bool Upvote { get; set; }
  public bool Like { get; set; }
}
