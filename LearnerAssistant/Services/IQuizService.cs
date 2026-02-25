using LearnerAssistant.Models;

namespace Services.Interfaces;

public interface IQuizService
{
  Task<IReadOnlyList<QuizQuestionDto>> GetQuizByChapterAsync(Guid chapterId);
  Task<QuizResultDto> SubmitQuizAsync(QuizSubmissionDto submission);
}
