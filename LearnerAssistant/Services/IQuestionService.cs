using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace Services.Interfaces
{
  public interface IQuestionService
  {
    Task<QuestionResponseDto?> GetByIdAsync(Guid id);
    Task<IReadOnlyList<QuestionResponseDto>> GetAllByChapterAsync(Guid chapterId);
    Task<QuestionResponseDto> CreateAsync(QuestionCreateDto dto);
    Task<QuestionResponseDto?> UpdateAsync(QuestionDto dto);
    Task<bool> DeleteAsync(Guid id);
  }
}