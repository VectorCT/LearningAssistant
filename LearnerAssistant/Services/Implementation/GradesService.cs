using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class GradesService(
  ApplicationDbContext context) : IGradesService
{
  //test
  private readonly ApplicationDbContext _context = context;

  public async Task<Grade> CreateGradeAsync(string gradeName)
  {
    var grade = new Grade()
    {
      Id = Guid.NewGuid(),
      Name = gradeName
    };

    await _context.AddAsync(grade);
    await _context.SaveChangesAsync();
    return grade;
  }

  public async Task<IReadOnlyList<GradeDto>> GetGradesAsync()
    => await _context.Grades
      .Select(s => new GradeDto
      {
        Id = s.Id,
        Name = s.Name
      }).ToReadOnlyListAsync();

  public async Task<IReadOnlyList<GradeDto>> GetGradeSubjectsAsync(Guid id)
  => await _context.Grades
    .Include(g => g.GradeSubjects)
    .ThenInclude(gs => gs.Subject)
    .Where(s => s.Id == id)
      .Select(s => new GradeDto
      {
        Id = s.Id,
        Name = s.Name,
        Subjects = s.GradeSubjects
        .Select(s => new SubjectDto
        {
          Id = s.Id,
          Name = s.Subject.Name,
          PrescribedTextBook = s.Subject.PrescribedTextBook
        }).ToArray()
      }).ToReadOnlyListAsync();
}
