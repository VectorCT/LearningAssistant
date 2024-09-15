using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface IGradesService
{
  Task<IReadOnlyList<GradeDto>> GetGradesAsync();
  Task<IReadOnlyList<GradeDto>> GetGradeSubjectsAsync(Guid id);
  Task<Grade> CreateGradeAsync(string gradeName);
}
