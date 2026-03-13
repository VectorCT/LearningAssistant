using LearnerAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace LearnerAssistant.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuizController(IQuizService quizService) : ControllerBase
{
  private readonly IQuizService _quizService = quizService;

  [HttpGet("by-chapter/{chapterId:guid}")]
  public async Task<IActionResult> GetByChapter(Guid chapterId)
  {
    var quiz = await _quizService.GetQuizByChapterAsync(chapterId);
    return Ok(quiz);
  }

  [HttpPost("submit")]
  public async Task<IActionResult> Submit([FromBody] QuizSubmissionDto submission)
  {
    var result = await _quizService.SubmitQuizAsync(submission);
    return Ok(result);
  }
}
