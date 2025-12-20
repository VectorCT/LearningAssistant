using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers;

[Route("[controller]")]
[ApiController]
public class ChapterSectionsController(IChapterSectionService service) : ControllerBase
{
  private readonly IChapterSectionService _service = service;

  [HttpPost]
  [Consumes("multipart/form-data")]
  public async Task<IActionResult> Create([FromForm] ChapterSectionCreateDto dto)
  {
    var created = await _service.CreateAsync(dto);
    return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
  }

  [HttpPut("{id}")]
  [Consumes("multipart/form-data")]
  public async Task<IActionResult> Update(Guid id, [FromForm] ChapterSectionDto dto)
  {
    if (id != dto.Id) return BadRequest();
    var updated = await _service.UpdateAsync(dto);
    return updated == null ? NotFound() : Ok(updated);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(Guid id)
  {
    var deleted = await _service.DeleteAsync(id);
    return deleted ? NoContent() : NotFound();
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(Guid id)
  {
    var section = await _service.GetByIdAsync(id);
    return section == null ? NotFound() : Ok(section);
  }

  [HttpGet("by-chapter/{chapterId}")]
  public async Task<IActionResult> GetByChapter(Guid chapterId)
  {
    var sections = await _service.GetAllByChapterAsync(chapterId);
    return Ok(sections);
  }
}
