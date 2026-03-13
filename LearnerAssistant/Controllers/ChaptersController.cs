using DataAccessLayer.Models;
using LearnerAssistant.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace LearnerAssistant.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChaptersController(IChapterService chapterService) : ControllerBase
{
  private readonly IChapterService _chapterService = chapterService;

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var chapters = await _chapterService.GetAllChaptersAsync();
    return Ok(chapters);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(Guid id)
  {
    var chapter = await _chapterService.GetChapterByIdAsync(id);
    return chapter != null ? Ok(chapter) : NotFound();
  }

  [HttpPost]
  public async Task<IActionResult> Create([FromForm] ChapterDto chapter)
  {
    var created = await _chapterService.CreateChapterAsync(chapter);
    return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Update(Guid id, [FromBody] Chapter chapter)
  {
    if (id != chapter.Id) return BadRequest();

    var updated = await _chapterService.UpdateChapterAsync(chapter);
    return Ok(updated);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(Guid id)
  {
    var deleted = await _chapterService.DeleteChapterAsync(id);
    return deleted ? NoContent() : NotFound();
  }
}
