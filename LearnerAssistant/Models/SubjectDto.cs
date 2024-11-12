namespace LearnerAssistant.Models;

public class SubjectDto
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string PrescribedTextBook { get; set; } = string.Empty;
  public int YearNumber { get; set; }
  public IFormFile PrescribedTextbookFileUrl { get; set; }
  public IFormFile SubjectImageUrl { get; set; }
  public string Description { get; set; } = string.Empty;
  public GradeLookupEnum Grade {  get; set; }
}
