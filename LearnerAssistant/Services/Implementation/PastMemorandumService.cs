using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class PastMemorandumService(
  ApplicationDbContext context) : IPastMemorandumService
{
  private readonly ApplicationDbContext _context = context;
  private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "PastMemorandums");
  public async Task<FileDownloadDto> DownloadPastPaper(Guid id)
  {
    var fileName = await _context.PastMemorandums
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

  public async Task<IReadOnlyList<PastMemoDto>> GetPastMemosAsync()
  => await _context.PastMemorandums
    .Select(p => new PastMemoDto
    {
      FileName = p.FileName,
      FilePath = p.FilePath,
      CreatedAt = DateTime.Now,
    }).ToReadOnlyListAsync();

  public Task<IReadOnlyList<PastMemoDto>> GetPastMemosBySubject(Guid subjectId)
  {
    throw new NotImplementedException();
  }

  public async Task<PastMemorandum> UploadPastMemo(PastMemoDto request)
  {
    var pastMemo = new PastMemorandum
    {
      Id = Guid.NewGuid(),
      PastPaperId = request.pastPaperId,
      FileName = request.FileName,
      FilePath= request.FilePath,
      CreatedAt= DateTime.Now,
    };

    await _context.PastMemorandums.AddAsync(pastMemo);
    await _context.SaveChangesAsync();
    return pastMemo;
  }
}
