using DataAccessLayer.Models;
using System.Text.Json.Serialization;

public class Year
{
  public Guid Id { get; set; }
  public int YearNumber { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }
  public List<TermYear> TermYears { get; set; } = [];
  public List<PastPaper> PastPapers { get; set; } = [];
  [JsonIgnore]
  public List<SubjectYear> SubjectYears { get; set; } = [];
}
