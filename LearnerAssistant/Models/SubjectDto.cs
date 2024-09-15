namespace LearnerAssistant.Models;

public class SubjectDto
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string PrescribedTextBook { get; set; } = string.Empty;
}
