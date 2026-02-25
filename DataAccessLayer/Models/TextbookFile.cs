namespace DataAccessLayer.Models;

public class TextbookFile
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public Subject Subject { get; set; }
  public string FileName { get; set; }
  public string FilePath { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }
}
