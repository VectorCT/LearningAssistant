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
    public async Task<IActionResult> CreateAsync(string name, string textBook)
      => Ok(await _subject.CreateSubjectAsync(name, textBook));
  }
}
