using LearnerAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace LearnerAssistant.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionsController(IQuestionService service) : ControllerBase
  {
    private readonly IQuestionService _service = service;

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
      var q = await _service.GetByIdAsync(id);
      return q == null ? NotFound() : Ok(q);
    }

    [HttpGet("by-chapter/{chapterId:guid}")]
    public async Task<IActionResult> GetByChapter(Guid chapterId)
    {
      var list = await _service.GetAllByChapterAsync(chapterId);
      return Ok(list);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] QuestionCreateDto dto)
    {
      var created = await _service.CreateAsync(dto);
      return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] QuestionDto dto)
    {
      if (id != dto.Id) return BadRequest();
      var updated = await _service.UpdateAsync(dto);
      return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
      var ok = await _service.DeleteAsync(id);
      return ok ? NoContent() : NotFound();
    }
  }
}