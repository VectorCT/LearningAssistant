using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class PastPapersService(
  ApplicationDbContext context) : IPastPapersService
{
  private readonly ApplicationDbContext _context = context;
  private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "PastPapers");
/// <inheritdoc/>

  public async Task<FileDownloadDto> DownloadPastPaper(Guid id)
  {
    var fileName = await _context.PastPapers
      .Where(p => p.Id == id)
      .Select(x => x.FileName)
      .FirstOrDefaultAsync();

    if (string.IsNullOrEmpty(fileName))
    {
      return new FileDownloadDto();
    }

    var filePath = Path.Combine(_basePath, fileName);

    if (!File.Exists(filePath))
    {
      throw new FileNotFoundException("The requested file was not found.");
    }

    var fileBytes = await File.ReadAllBytesAsync(filePath);

    return new FileDownloadDto
    {
      FileName = fileName,
      FileBytes = fileBytes
    };
  }

  public async Task<IReadOnlyList<PastPaperDto>> GetPastPapersAsync()
  => await _context.PastPapers
    .Select(p => new PastPaperDto
    {
      Id = p.Id,
      SubjectId = p.SubjectId,
      FileName = p.FileName,
      FilePath = p.FilePath,
      CreatedAt = DateTime.Now,
    }).ToReadOnlyListAsync();

  public async Task<IReadOnlyList<PastPaperDto>> GetPastPapersBySubject(Guid subjectId)
  => await _context.PastPapers
          .Where(p => p.SubjectId == subjectId)
          .Select(p => new PastPaperDto
          {
            Id = p.Id,
            FileName = p.FileName,
            FilePath= p.FilePath,
          })
          .ToReadOnlyListAsync();
/// <inheritdoc/>

  public async Task<PastPaper> UploadPastPaper(PastPaperDto request)
  {
    try
    {

      var filePath = Path.Combine(_basePath);

      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }
      var completePath = Path.Combine(_basePath, request.File.FileName);
      using (var stream = new FileStream(completePath, FileMode.Create))
      {
        await request.File.CopyToAsync(stream);
      };

      var pastPaper = new PastPaper
      {
        FileName = request.File.FileName,
        FilePath = completePath,
        SubjectId = request.SubjectId,
        CreatedAt = DateTime.UtcNow
      };

      await _context.PastPapers.AddAsync(pastPaper);
      await _context.SaveChangesAsync();
      return pastPaper;
    }
    catch (Exception ex) { throw new Exception(ex.Message); };
  }
}
