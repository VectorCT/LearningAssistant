using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace Services.Interfaces
{
  public interface IAnswerService
  {
    Task<AnswerResponseDto?> GetByIdAsync(Guid id);
    Task<IReadOnlyList<AnswerResponseDto>> GetAllByQuestionAsync(Guid questionId);

    Task<AnswerResponseDto> CreateMultipleChoiceAsync(MultipleChoiceAnswerCreateDto dto);
    Task<AnswerResponseDto> CreateTrueFalseAsync(TrueFalseAnswerCreateDto dto);

    Task<AnswerResponseDto?> UpdateMultipleChoiceAsync(MultipleChoiceAnswerDto dto);
    Task<AnswerResponseDto?> UpdateTrueFalseAsync(TrueFalseAnswerDto dto);

    Task<bool> DeleteAsync(Guid id);
  }
}