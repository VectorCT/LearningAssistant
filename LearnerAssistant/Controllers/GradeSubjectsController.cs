using DataAccessLayer.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers;

[Route("[controller]")]
[ApiController]
public class GradeSubjectsController(
  IGradeSubjectsService gradeSubjects) : ControllerBase
{
  private readonly IGradeSubjectsService _gradeSubjects = gradeSubjects;

  [HttpPost]
  public async Task<IActionResult> CreateAsync(Guid gradeId, Guid subjectId)
    => Ok(await _gradeSubjects.CreateGradeSubjectAsync(gradeId, subjectId));
}
