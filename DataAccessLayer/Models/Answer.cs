namespace DataAccessLayer.Models;

public abstract class Answer
{
  public Guid Id { get; set; }
  public string Description { get; set; } = string.Empty;

  // Foreign key
  public Guid QuestionId { get; set; }
  public Question Question { get; set; }

  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }
}

