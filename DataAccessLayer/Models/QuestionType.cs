namespace DataAccessLayer.Models;

public class QuestionType
{
  public Guid Id { get; set; }
  public string TypeName { get; set; } = string.Empty;  // e.g., "True/False", "Multiple Choice", etc.

  // Navigation property
  public ICollection<Question> Questions { get; set; } = new List<Question>();
}
