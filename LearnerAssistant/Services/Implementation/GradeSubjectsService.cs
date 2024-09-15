using DataAccessLayer.Context;
using DataAccessLayer.Models;

namespace LearnerAssistant.Services.Implementation;

public class GradeSubjectsService(
  ApplicationDbContext context) : IGradeSubjectsService
{
  private readonly ApplicationDbContext _context = context;

  public async Task<Guid> CreateGradeSubjectAsync(Guid gradeId, Guid subjectId)
  {
    var model = new GradeSubject
    {
      Id = Guid.NewGuid(),
      GradeId = gradeId,
      SubjectId = subjectId
    };
    await _context.AddAsync(model);
    await _context.SaveChangesAsync();

    return model.Id;
  }
}
