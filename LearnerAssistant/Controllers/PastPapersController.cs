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
    public async Task<IActionResult> UploadPastPaper(
      IFormFile paper,
      IFormFile pastMemo,
      [FromForm] Guid subjectId,
      [FromForm] Guid yearId)
    {
      if (paper == null || paper.Length == 0)
        return BadRequest("No Past Paper uploaded.");

      if (pastMemo == null || pastMemo.Length == 0)
        return BadRequest("No Past Paper uploaded.");

      var pastPaper = new PastPaperDto
      {
        File = paper,
        Memorandum = pastMemo,
        SubjectId = subjectId,
        YearId = yearId
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
