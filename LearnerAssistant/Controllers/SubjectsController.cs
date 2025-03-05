using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SubjectsController(
    ISubjectsService subject) : ControllerBase
  {
    private readonly ISubjectsService _subject = subject;

    [HttpGet]
    public async Task<IActionResult> Get()
      => Ok(await _subject.GetSubjectsAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
      => Ok(await _subject.GetSubjectByIdAsync(id));

    [HttpGet()]
    [Route("Grade")]
    public async Task<IActionResult> GetByGradeAsync(Guid gradeId)
      => Ok(await _subject.GetSubjectsByGradeAsync(gradeId));

    [HttpGet("Year")]
    public async Task<IActionResult> GetByYearAsync(Guid yearId)
      => Ok(await _subject.GetSubjectsByYearAsync(yearId));

    [HttpPost]
    public async Task<IActionResult> CreateAsync(SubjectDto model)
      => Ok(await _subject.CreateSubjectAsync(model));
  }
}
