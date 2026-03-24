
namespace DataAccessLayer.Models
{
  public class PastMemorandum
  {
    public Guid Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public Guid? PastPaperId { get; set; }
    public PastPaper? PastPaper { get; set; }
  }
}
