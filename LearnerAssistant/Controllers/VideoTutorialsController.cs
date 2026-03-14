using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VideoTutorialsController(IVideoTutorialService videoTutorialService) : ControllerBase
{
  private readonly IVideoTutorialService _videoTutorialService = videoTutorialService;

  /// <summary>
  /// Get all video tutorials
  /// </summary>
  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var videos = await _videoTutorialService.GetAllVideoTutorialsAsync();
    return Ok(videos);
  }

  /// <summary>
  /// Get video tutorial by ID
  /// </summary>
  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(Guid id)
  {
    var video = await _videoTutorialService.GetVideoTutorialByIdAsync(id);
    
    if (video == null)
      return NotFound();

    return Ok(video);
  }

  /// <summary>
  /// Get all video tutorials for a specific subject
  /// </summary>
  [HttpGet("subject/{subjectId}")]
  public async Task<IActionResult> GetBySubject(Guid subjectId)
  {
    var videos = await _videoTutorialService.GetVideoTutorialsBySubjectAsync(subjectId);
    return Ok(videos);
  }

  /// <summary>
  /// Upload a new video tutorial
  /// </summary>
  [HttpPost("Upload")]
  [Consumes("multipart/form-data")]
  public async Task<IActionResult> Upload(
    [FromForm] IFormFile video,
    [FromForm] Guid subjectId,
    [FromForm] string videoName,
    [FromForm] string? createdBy)
  {
    if (video == null || video.Length == 0)
      return BadRequest("No video file uploaded.");

    var videoDto = new VideoTutorialDto
    {
      Video = video,
      SubjectId = subjectId,
      VideoName = videoName,
      CreatedBy = createdBy
    };

    try
    {
      var result = await _videoTutorialService.UploadVideoTutorialAsync(videoDto);
      return Ok(new { result.Id, result.VideoPath, result.VideoName });
    }
    catch (ArgumentException ex)
    {
      return BadRequest(ex.Message);
    }
    catch (Exception ex)
    {
      return StatusCode(500, ex.Message);
    }
  }

  /// <summary>
  /// Download a video tutorial file
  /// </summary>
  [HttpGet("Download/{id}")]
  public async Task<IActionResult> Download(Guid id)
  {
    try
    {
      var fileDownloadDto = await _videoTutorialService.DownloadVideoTutorialAsync(id);

      if (fileDownloadDto == null)
      {
        return NotFound("Video not found.");
      }

      return File(
        fileDownloadDto.FileBytes,
        "video/mp4",
        fileDownloadDto.FileName
      );
    }
    catch (FileNotFoundException ex)
    {
      return NotFound(ex.Message);
    }
    catch (Exception ex)
    {
      return StatusCode(500, ex.Message);
    }
  }

  /// <summary>
  /// Delete a video tutorial
  /// </summary>
  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(Guid id)
  {
    var deleted = await _videoTutorialService.DeleteVideoTutorialAsync(id);
    
    if (!deleted)
      return NotFound();

    return NoContent();
  }
}
