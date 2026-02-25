namespace DataAccessLayer.Models;

public class Term
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Duration { get; set; } = string.Empty;
  public DateTime? StartDate { get; set; }
  public DateTime? EndDate { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }
  public List<Chapter> Chapters { get; set; } = [];
  public List<TermYear> TermYears { get; set; } = [];
}
