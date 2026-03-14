namespace LearnerAssistant.Models;

public class VideoTutorialDto
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public string VideoName { get; set; } = string.Empty;
  public string VideoPath { get; set; } = string.Empty;
  public IFormFile? Video { get; set; }
  public DateTime CreatedAt { get; set; }
  public string? CreatedBy { get; set; }
}
