using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;

namespace LearnerAssistant.Services.Implementation;

public class SubjectsService(
  ApplicationDbContext context) : ISubjectsService
{
  private readonly ApplicationDbContext _context = context;

  public async Task<Subject> CreateSubjectAsync(SubjectDto model)
  {
    var subject = new Subject()
    {
      Id = Guid.NewGuid(),
      Name = model.Name,
      PrescribedTextBook = model.PrescribedTextBook,
      SubjectDescription = model.Description,
      SubjectImageUrl = model.SubjectImageUrl,
      PrescribedTextBookFileUrl = model.PrescribedTextbookFileUrl,
    };

    await _context.AddAsync(subject);
    await _context.SaveChangesAsync();

    return subject;

  }
/// <inheritdoc/>

  public async Task<IReadOnlyList<SubjectDto>> GetSubjectsAsync()
  => await _context.Subjects
      .Select(s => new SubjectDto
      {
        Id = s.Id,
        Name = s.Name,
        PrescribedTextBook = s.PrescribedTextBook,
        Description = s.SubjectDescription,
      }).ToReadOnlyListAsync();
}
