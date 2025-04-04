using Azure.Core;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;
using LearnerAssistant.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class SubjectsService(
  ApplicationDbContext context) : ISubjectsService
{
  private readonly ApplicationDbContext _context = context;
  private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "Subjects");
  public async Task<Subject> CreateSubjectAsync(SubjectDto model)
  {
    var subject = new Subject()
    {
      Id = Guid.NewGuid(),
      Name = model.Name,
      PrescribedTextBook = model.PrescribedTextBook,
      SubjectDescription = model.Description,
      SubjectImageUrl = await GetFilePath(model.SubjectImageUrl),
      PrescribedTextBookFileUrl = await GetFilePath(model.PrescribedTextbookFileUrl),
    };

    await _context.AddAsync(subject);
    await _context.SaveChangesAsync();

    var subjectGrade = new SubjectDto
    {
      Id = subject.Id,
      Grade = model.Grade,
    };
    var subjectYear = new SubjectDto
    {
      Id = subject.Id,
      YearNumber = model.YearNumber,
    };

    await CreateGradeSubjectAsync(subjectGrade);
    await CreateSubjectYearAsync(subjectYear);

    return subject;

  }
  /// <inheritdoc/>

  public async Task<IReadOnlyList<SubjectResponseDto>> GetSubjectsAsync()
  => await _context.Subjects
      .Select(s => new SubjectResponseDto
      {
        Id = s.Id,
        Name = s.Name,
        PrescribedTextBook = s.PrescribedTextBook,
        Description = s.SubjectDescription,
        SubjectImageUrl = s.SubjectImageUrl,
        PrescribedTextbookFileUrl = s.PrescribedTextBookFileUrl,
        Grade = s.GradeSubjects.FirstOrDefault().Grade.Name,
        Year = s.SubjectYears.FirstOrDefault().Year.YearNumber.ToString(),
      }).ToReadOnlyListAsync();


  public async Task<IReadOnlyList<SubjectResponseDto>> GetSubjectByIdAsync(Guid id)
  => await _context.Subjects.Where(s => s.Id == id)
    .Select(s => new SubjectResponseDto
    {
      Id = s.Id,
      Name = s.Name,
      Description = s.SubjectDescription,
      SubjectImageUrl = s.SubjectImageUrl,
      PrescribedTextBook = s.PrescribedTextBook,
      Grade = s.GradeSubjects.FirstOrDefault().Grade.Name,
      Year = s.SubjectYears.FirstOrDefault().Year.YearNumber.ToString(),
    }).ToReadOnlyListAsync();


  public async Task<IReadOnlyList<SubjectResponseDto>> GetSubjectsByGradeAsync(Guid gradeId)
  => await _context.Subjects
      .Where(s => s.GradeSubjects.Any(s => s.GradeId == gradeId))
      .Select(s => new SubjectResponseDto
      {
        Id = s.Id,
        Name = s.Name,
        Description = s.SubjectDescription,
        SubjectImageUrl = s.SubjectImageUrl,
        PrescribedTextBook = s.PrescribedTextBook,
        Grade = s.GradeSubjects.FirstOrDefault().Grade.Name,
        Year = s.SubjectYears.FirstOrDefault().Year.YearNumber.ToString(),
      }).ToReadOnlyListAsync();
  public async Task<IReadOnlyList<SubjectResponseDto>> GetSubjectsByYearAsync(Guid yearId)
  => await _context.Subjects
      .Where(s => s.SubjectYears.Any(s => s.YearId == yearId))
      .Select(s => new SubjectResponseDto
      {
        Id = s.Id,
        Name = s.Name,
        Description = s.SubjectDescription,
        SubjectImageUrl = s.SubjectImageUrl,
        PrescribedTextBook = s.PrescribedTextBook,
        Grade = s.GradeSubjects.FirstOrDefault().Grade.Name,
        Year = s.SubjectYears.FirstOrDefault().Year.YearNumber.ToString(),
      }).ToReadOnlyListAsync();

  public Task<Subject> UpdateSubjectAsync(SubjectDto model)
  {
    throw new NotImplementedException();
  }

  public Task<Subject> DeleteSubjectAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  private async Task<string> GetFilePath(IFormFile file)
  {
    var filePath = Path.Combine(_basePath);

    if (!Directory.Exists(filePath))
    {
      Directory.CreateDirectory(filePath);
    }
    var completePath = Path.Combine(_basePath, file.FileName);
    using (var stream = new FileStream(completePath, FileMode.Create))
    {
      await file.CopyToAsync(stream);
    };
    return completePath;
  }
  private async Task<GradeSubject> CreateGradeSubjectAsync(SubjectDto grade)
  {
    var gradeId = _context.Grades
      .FirstOrDefault(g => g.Name == MapToDatabaseFormat(grade.Grade))?.Id;

    var gradeSubject = new GradeSubject
    {
      Id = Guid.NewGuid(),
      SubjectId = grade.Id,
      GradeId = (Guid)gradeId
    };

    await _context.AddAsync(gradeSubject);
    await _context.SaveChangesAsync();
    return gradeSubject;
  }
  private static string MapToDatabaseFormat(GradeLookupEnum grade)
  {
    switch (grade)
    {
      case GradeLookupEnum.Grade8:
        return "Grade 8";
      case GradeLookupEnum.Grade9:
        return "Grade 9";
      case GradeLookupEnum.Grade10:
        return "Grade 10";
      case GradeLookupEnum.Grade11:
        return "Grade 11";
      case GradeLookupEnum.Grade12:
        return "Grade 12";
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  private async Task<SubjectYear> CreateSubjectYearAsync(SubjectDto request)
  {
    var yearId = _context.Years
      .FirstOrDefault(y => y.YearNumber == request.YearNumber)?.Id;

    var subjectYear = new SubjectYear
    {
      SubjectId = request.Id,
      YearId = (Guid)yearId
    };

    await _context.AddAsync(subjectYear);
    await _context.SaveChangesAsync();
    return subjectYear;
  }
}
