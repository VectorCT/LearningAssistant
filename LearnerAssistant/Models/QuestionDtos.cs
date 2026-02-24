namespace LearnerAssistant.Models
{
  public class QuestionCreateDto
  {
    public Guid ChapterId { get; set; }
    public Guid QuestionTypeId { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public int PointValue { get; set; }

    // Multiple-choice metadata (optional; used when QuestionType is Multiple Choice)
    public List<string>? Options { get; set; } = new List<string>();
    // 1 for single-select, 2 for two-select
    public int? MaxSelections { get; set; } = 1;
  }

  public class QuestionDto : QuestionCreateDto
  {
    public Guid Id { get; set; }
  }

  public class QuestionResponseDto
  {
    public Guid Id { get; set; }
    public Guid ChapterId { get; set; }
    public Guid QuestionTypeId { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public int PointValue { get; set; }

    // Multiple-choice metadata (present when applicable)
    public List<string>? Options { get; set; } = new List<string>();
    public int? MaxSelections { get; set; } = 1;
  }
}