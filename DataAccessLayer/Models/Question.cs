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

  // Multiple-choice metadata (only used when QuestionType is Multiple Choice)
  // Options presented to the user for selection.
  public List<string> Options { get; set; } = new List<string>();

  // Maximum number of selections allowed from Options.
  // For single-select set to 1, for two-select set to 2.
  public int MaxSelections { get; set; } = 1;

  // Polymorphic relationship
  public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
