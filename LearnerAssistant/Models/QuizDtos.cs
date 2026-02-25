namespace LearnerAssistant.Models;

public class QuizQuestionDto
{
  public Guid Id { get; set; }
  public string QuestionText { get; set; } = string.Empty;
  public int PointValue { get; set; }
  public List<string> Options { get; set; } = new();
  public int MaxSelections { get; set; } = 1;
  public Guid QuestionTypeId { get; set; }
}

public class QuizSubmissionDto
{
  public Guid ChapterId { get; set; }
  public List<QuestionAnswerSubmission> Answers { get; set; } = new();
}

public class QuestionAnswerSubmission
{
  public Guid QuestionId { get; set; }
  public List<string>? SelectedOptions { get; set; }
}

public class QuizResultDto
{
  public int TotalScore { get; set; }
  public int MaxScore { get; set; }
  public List<QuestionResultDto> QuestionResults { get; set; } = new();
}

public class QuestionResultDto
{
  public Guid QuestionId { get; set; }
  public bool IsCorrect { get; set; }
  public int AwardedPoints { get; set; }
  public List<string> CorrectOptions { get; set; } = new();
}
