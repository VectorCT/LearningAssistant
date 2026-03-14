using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Extensions;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class VideoTutorialService(ApplicationDbContext context) : IVideoTutorialService
{
  private readonly ApplicationDbContext _context = context;
  private readonly string _basePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "VideoTutorials");

  public async Task<IReadOnlyList<VideoTutorialDto>> GetAllVideoTutorialsAsync()
  {
    return await _context.VideoTutorials
      .Select(v => new VideoTutorialDto
      {
        Id = v.Id,
        SubjectId = v.SubjectId,
        VideoName = v.VideoName,
        VideoPath = v.VideoPath,
        CreatedAt = v.CreatedAt,
      })
      .ToReadOnlyListAsync();
  }

  public async Task<VideoTutorialDto?> GetVideoTutorialByIdAsync(Guid id)
  {
    var video = await _context.VideoTutorials
      .Where(v => v.Id == id)
      .Select(v => new VideoTutorialDto
      {
        Id = v.Id,
        SubjectId = v.SubjectId,
        VideoName = v.VideoName,
        VideoPath = v.VideoPath,
        CreatedAt = v.CreatedAt,
        CreatedBy = v.CreatedBy
      })
      .FirstOrDefaultAsync();

    return video;
  }

  public async Task<IReadOnlyList<VideoTutorialDto>> GetVideoTutorialsBySubjectAsync(Guid subjectId)
  {
    return await _context.VideoTutorials
      .Where(v => v.SubjectId == subjectId)
      .Select(v => new VideoTutorialDto
      {
        Id = v.Id,
        SubjectId = v.SubjectId,
        VideoName = v.VideoName,
        VideoPath = v.VideoPath,
        CreatedAt = v.CreatedAt,
        CreatedBy = v.CreatedBy
      })
      .ToReadOnlyListAsync();
  }

  public async Task<VideoTutorial> UploadVideoTutorialAsync(VideoTutorialDto request)
  {
    try
    {
      if (request.Video == null || request.Video.Length == 0)
        throw new ArgumentException("No video file provided.");

      var videoTutorial = new VideoTutorial
      {
        Id = Guid.NewGuid(),
        SubjectId = request.SubjectId,
        VideoName = request.VideoName,
        VideoPath = await SaveVideoFileAsync(request.Video),
        CreatedAt = DateTime.UtcNow,
        CreatedBy = request.CreatedBy
      };

      await _context.VideoTutorials.AddAsync(videoTutorial);
      await _context.SaveChangesAsync();

      return videoTutorial;
    }
    catch (Exception ex)
    {
      throw new Exception($"Error uploading video tutorial: {ex.Message}", ex);
    }
  }

  public async Task<FileDownloadDto> DownloadVideoTutorialAsync(Guid id)
  {
    var video = await _context.VideoTutorials
      .Where(v => v.Id == id)
      .Select(v => new { v.VideoName, v.VideoPath })
      .FirstOrDefaultAsync();

    if (video == null)
    {
      throw new FileNotFoundException("Video tutorial not found.");
    }

    var fileName = Path.GetFileName(video.VideoPath);
    var filePath = video.VideoPath;

    if (!File.Exists(filePath))
    {
      throw new FileNotFoundException("The video file was not found on the server.");
    }

    var fileBytes = await File.ReadAllBytesAsync(filePath);

    return new FileDownloadDto
    {
      FileName = fileName,
      FileBytes = fileBytes
    };
  }

  public async Task<bool> DeleteVideoTutorialAsync(Guid id)
  {
    var video = await _context.VideoTutorials.FindAsync(id);

    if (video == null)
      return false;

    // Delete the physical file
    if (File.Exists(video.VideoPath))
    {
      File.Delete(video.VideoPath);
    }

    _context.VideoTutorials.Remove(video);
    await _context.SaveChangesAsync();

    return true;
  }

  private async Task<string> SaveVideoFileAsync(IFormFile file)
  {
    if (!Directory.Exists(_basePath))
    {
      Directory.CreateDirectory(_basePath);
    }

    var fileName = $"{Guid.NewGuid()}_{file.FileName}";
    var completePath = Path.Combine(_basePath, fileName);

    using (var stream = new FileStream(completePath, FileMode.Create))
    {
      await file.CopyToAsync(stream);
    }

    return completePath;
  }
}
