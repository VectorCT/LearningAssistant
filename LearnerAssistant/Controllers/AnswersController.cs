using LearnerAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace LearnerAssistant.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class AnswersController(IAnswerService service) : ControllerBase
  {
    private readonly IAnswerService _service = service;

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
      var a = await _service.GetByIdAsync(id);
      return a == null ? NotFound() : Ok(a);
    }

    [HttpGet("by-question/{questionId:guid}")]
    public async Task<IActionResult> GetByQuestion(Guid questionId)
    {
      var list = await _service.GetAllByQuestionAsync(questionId);
      return Ok(list);
    }

    [HttpPost("multiple-choice")]
    public async Task<IActionResult> CreateMultipleChoice([FromBody] MultipleChoiceAnswerCreateDto dto)
    {
      var created = await _service.CreateMultipleChoiceAsync(dto);
      return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPost("true-false")]
    public async Task<IActionResult> CreateTrueFalse([FromBody] TrueFalseAnswerCreateDto dto)
    {
      var created = await _service.CreateTrueFalseAsync(dto);
      return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("multiple-choice/{id:guid}")]
    public async Task<IActionResult> UpdateMultipleChoice(Guid id, [FromBody] MultipleChoiceAnswerDto dto)
    {
      if (id != dto.Id) return BadRequest();
      var updated = await _service.UpdateMultipleChoiceAsync(dto);
      return updated == null ? NotFound() : Ok(updated);
    }

    [HttpPut("true-false/{id:guid}")]
    public async Task<IActionResult> UpdateTrueFalse(Guid id, [FromBody] TrueFalseAnswerDto dto)
    {
      if (id != dto.Id) return BadRequest();
      var updated = await _service.UpdateTrueFalseAsync(dto);
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