namespace DataAccessLayer.Models;

public class PastPaper
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public Subject? Subject { get; set; }
  public Guid YearId { get; set; }
  public Year Year { get; set; }
  public string FileName { get; set; } = string.Empty;
  public string FilePath { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }
  public PastMemorandum? PastMemorandum { get; set; }
}
