using DataAccessLayer.Models;

namespace LearnerAssistant.Services;

public interface IGradeSubjectsService
{
  Task<Guid> CreateGradeSubjectAsync(Guid gradeId, Guid subjectId);
}
