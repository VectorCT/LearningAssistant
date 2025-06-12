namespace LearnerAssistant.Models;
public class CommentDto
{
  public Guid ForumId { get; set; }
  public string CommentText { get; set; } = string.Empty;
  public Guid? ParentCommentId { get; set; }
}
