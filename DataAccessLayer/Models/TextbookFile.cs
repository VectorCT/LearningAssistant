namespace DataAccessLayer.Models;

public class TextbookFile
{
  public int Id { get; set; }
  public int SubjectId { get; set; }
  public Subject Subject { get; set; }
  public string FileName { get; set; }
  public string FilePath { get; set; }
  public DateTime CreatedAt { get; set; }
}
