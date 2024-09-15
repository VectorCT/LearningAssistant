
namespace DataAccessLayer.Models;

public class Question
{
  public Guid Id { get; set; }
  public string QuestionText { get; set; } = string.Empty;
  public int PointValue { get; set; }

  public Guid ChapterId { get; set; }
  public Chapter Chapter { get; set; }

  public Guid QuestionTypeId { get; set; }
  public QuestionType QuestionType { get; set; }

  // Polymorphic relationship
  public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
