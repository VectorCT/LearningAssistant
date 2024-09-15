namespace DataAccessLayer.Models;

public abstract class Answer
{
  public Guid Id { get; set; }
  public string Description { get; set; } = string.Empty;

  // Foreign key
  public Guid QuestionId { get; set; }
  public Question Question { get; set; }
}

