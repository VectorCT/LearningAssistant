using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class SubjectsService(
  ApplicationDbContext context) : ISubjectsService
{
  private readonly ApplicationDbContext _context = context;

  public async Task<Subject> CreateSubjectAsync(string name, string prescribedTextbook)
  {
    var subject = new Subject()
    {
      Id = Guid.NewGuid(),
      Name = name,
      PrescribedTextBook = prescribedTextbook
    };

    await _context.AddAsync(subject);
    await _context.SaveChangesAsync();

    return subject;

  }

  public async Task<IReadOnlyList<SubjectDto>> GetSubjectsAsync()
  => await _context.Subjects
      .Select(s => new SubjectDto
      {
        Id = s.Id,
        Name = s.Name,
        PrescribedTextBook = s.PrescribedTextBook,
      }).ToReadOnlyListAsync();
}
