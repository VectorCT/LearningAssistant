
namespace DataAccessLayer.Models;

public class Comment
{
  public Guid Id { get; set; }
  public Guid ForumId { get; set; }
  public Forum? Forum { get; set; }
  public string UserId { get; set; } = string.Empty;
  public ApplicationUser User { get; set; } = null!;
  public string CommentText { get; set; } = string.Empty;
  public Guid? ParentCommentId { get; set; }
  public Comment? ParentComment { get; set; }
  public List<Comment> Replies { get; set; } = [];
  public List<UserReaction> UserReactions { get; set; } = [];
  public int Upvotes { get; set; }
  public int Likes { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.Now;
}
