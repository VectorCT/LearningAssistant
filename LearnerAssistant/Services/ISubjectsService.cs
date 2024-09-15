using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface ISubjectsService
{
  Task<IReadOnlyList<SubjectDto>> GetSubjectsAsync();
  Task<Subject> CreateSubjectAsync(string name, string prescribedTextbook);
}
