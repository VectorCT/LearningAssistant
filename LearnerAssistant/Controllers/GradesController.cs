using LearnerAssistant.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class GradesController(
    IGradesService grades) : ControllerBase
  {
    private readonly IGradesService _grades = grades;

    [HttpGet]
    public async Task<IActionResult> Get()
      => Ok(await _grades.GetGradesAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
      => Ok(await _grades.GetGradeSubjectsAsync(id));

    [HttpPost]
    public async Task<IActionResult> CreateAsync(string name)
      => Ok(await _grades.CreateGradeAsync(name));
  }
}
