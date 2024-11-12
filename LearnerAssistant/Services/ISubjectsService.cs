using DataAccessLayer.Models;
using LearnerAssistant.Models;
using LearnerAssistant.Models.Response;

namespace LearnerAssistant.Services;

public interface ISubjectsService
{
  Task<IReadOnlyList<SubjectResponseDto>> GetSubjectsAsync();
  Task<IReadOnlyList<SubjectResponseDto>> GetSubjectByIdAsync(Guid id);
  Task<IReadOnlyList<SubjectResponseDto>> GetSubjectsByGradeAsync(string grade);
  Task<IReadOnlyList<SubjectResponseDto>> GetSubjectsByYearAsync(int year);
  Task<Subject> CreateSubjectAsync(SubjectDto model);
  Task<Subject> UpdateSubjectAsync(SubjectDto model);
  Task<Subject> DeleteSubjectAsync(Guid id);
}
