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

    [HttpPost]
    public async Task<IActionResult> CreateAsync(SubjectDto model)
      => Ok(await _subject.CreateSubjectAsync(model));
  }
}
