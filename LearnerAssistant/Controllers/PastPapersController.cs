using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers
{
  /// <inheritdoc/>
  [Route("[controller]")]
  [ApiController]
  public class PastPapersController(
    IPastPapersService pastPapers) : ControllerBase
  {
    private readonly IPastPapersService _pastPapers = pastPapers;

    /// <inheritdoc/>
    [HttpPost("Upload")]
    public async Task<IActionResult> UploadPastPaper(IFormFile file, [FromForm] Guid subjectId)
    {
      if (file == null || file.Length == 0)
        return BadRequest("No file uploaded.");

      var pastPaper = new PastPaperDto
      {
        File = file,
        SubjectId = subjectId,
      };
      var result = await _pastPapers.UploadPastPaper(pastPaper);

      return Ok(new { result.Id, result.FilePath });
    }
    /// <inheritdoc/>
    [HttpGet("{subjectId}")]
    public async Task<IActionResult> GetPastPapersBySubject(Guid subjectId)
    {
      var pastPapers = await _pastPapers.GetPastPapersBySubject(subjectId);

      if (pastPapers == null)
      {
        return NotFound();
      }

      return Ok(pastPapers);
    }
    /// <inheritdoc/>
    [HttpGet("Download/{Id}")]
    public async Task<IActionResult> DownloadFile(Guid Id)
    {
      try
      {
        var fileDownloadDto = await _pastPapers.DownloadPastPaper(Id);

        if (fileDownloadDto == null)
        {
          return NotFound("File not found.");
        }

        return File(
          fileDownloadDto.FileBytes,
          "application/octet-stream",
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
  }
}
