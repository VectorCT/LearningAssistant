namespace DataAccessLayer.Models;

public class PastPaper
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public Subject? Subject { get; set; }
  public string FileName { get; set; } = string.Empty;
  public string FilePath { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
  public List<PastPaperMemorandum> PastPaperMemorandums { get; set; } = [];
}
