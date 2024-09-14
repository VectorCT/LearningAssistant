
namespace DataAccessLayer.Models;

public class VideoTutorial
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public Subject? Subject { get; set; }
  public string VideoName { get; set; } = string.Empty;
  public string VideoPath { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
}
