namespace DataAccessLayer.Models;

public class QuestionType
{
  public Guid Id { get; set; }
  public string TypeName { get; set; } = string.Empty;  // e.g., "True/False", "Multiple Choice", etc.
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }

  // Navigation property
  public ICollection<Question> Questions { get; set; } = new List<Question>();
}
