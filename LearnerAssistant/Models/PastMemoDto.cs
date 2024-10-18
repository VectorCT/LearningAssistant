namespace LearnerAssistant.Models;

public class PastMemoDto
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public IFormFile File { get; set; }
  public string FileName { get; set; } = string.Empty;
  public string FilePath { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
}
