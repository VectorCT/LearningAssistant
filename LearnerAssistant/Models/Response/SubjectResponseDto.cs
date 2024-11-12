namespace LearnerAssistant.Models.Response;

public class SubjectResponseDto
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string PrescribedTextBook { get; set; } = string.Empty;
  public int YearNumber { get; set; }
  public string PrescribedTextbookFileUrl { get; set; }
  public string SubjectImageUrl { get; set; }
  public string Description { get; set; } = string.Empty;
  public string Grade { get; set; }
  public string Year { get; set; }
}
