namespace LearnerAssistant.Models;

public class ForumDto
{
  public Guid Id { get; set; }
  public string Topic { get; set; } = string.Empty;
  public string DiscussionQuestion { get; set; } = string.Empty;
  public string? Screenshot { get; set; }
  public DateTime CreatedAt { get; set; }
  public Guid SubjectId { get; set; }
}
