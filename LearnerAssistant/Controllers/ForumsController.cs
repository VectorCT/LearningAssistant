using DataAccessLayer.Models;
using LearnerAssistant.Models;
using LearnerAssistant.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnerAssistant.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ForumsController(IForumService forumService) : ControllerBase
  {
    private readonly IForumService _forumService = forumService;

    [HttpPost]
    public async Task<IActionResult> CreateForum([FromForm] ForumDto forumDto, IFormFile? screenshot)
    {
      var createdForum = await _forumService.CreateForumAsync(forumDto, screenshot);
      return CreatedAtAction(nameof(GetForumById), new { id = createdForum.Id }, createdForum);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateForum(Guid id, [FromForm] Forum forumDto, IFormFile? screenshot)
    {
      if (id != forumDto.Id)
        return BadRequest();

      var updated = await _forumService.UpdateForumAsync(forumDto, screenshot);
      if (!updated)
        return NotFound();

      return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllForums()
    {
      var forums = await _forumService.GetAllForumsAsync();
      return Ok(forums);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetForumById(Guid id)
    {
      var forum = await _forumService.GetForumByIdAsync(id);
      if (forum == null)
        return NotFound();

      return Ok(forum);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteForum(Guid id)
    {
      var deleted = await _forumService.DeleteForumAsync(id);
      if (!deleted)
        return NotFound();

      return NoContent();
    }
  }
}
