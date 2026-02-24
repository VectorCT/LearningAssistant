namespace LearnerAssistant.Models
{
  // Create DTOs
  public abstract class BaseAnswerCreateDto
  {
    public Guid QuestionId { get; set; }
    public string Description { get; set; } = string.Empty;
  }

  public class MultipleChoiceAnswerCreateDto : BaseAnswerCreateDto
  {
    public List<string>? Options { get; set; } = [];
    public string CorrectOption { get; set; } = string.Empty;
    public string? Explanation { get; set; }
  }

  public class TrueFalseAnswerCreateDto : BaseAnswerCreateDto
  {
    public bool IsTrue { get; set; }
    public string? Explanation { get; set; }
  }

  // Update DTOs
  public class MultipleChoiceAnswerDto : MultipleChoiceAnswerCreateDto
  {
    public Guid Id { get; set; }
  }

  public class TrueFalseAnswerDto : TrueFalseAnswerCreateDto
  {
    public Guid Id { get; set; }
  }

  // Response DTO
  public class AnswerResponseDto
  {
    public Guid Id { get; set; }
    public Guid QuestionId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string AnswerType { get; set; } = string.Empty;

    // MultipleChoice fields
    public List<string>? Options { get; set; }
    public string? CorrectOption { get; set; }

    // Shared explanation
    public string? Explanation { get; set; }

    // TrueFalse fields
    public bool? IsTrue { get; set; }
  }
}