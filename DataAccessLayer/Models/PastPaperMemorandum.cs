
namespace DataAccessLayer.Models;

public class PastPaperMemorandum
{
  public Guid Id { get; set; }
  public Guid PastPaperId { get; set; }
  public PastPaper? PastPaper { get; set; }
  public Guid PastMemorandumId { get; set; }
  public PastMemorandum? PastMemorandum { get; set; }
}
