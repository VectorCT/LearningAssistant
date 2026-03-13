using DataAccessLayer.Context;
using DataAccessLayer.Models;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;

public class ForumService : IForumService
{
  private readonly ApplicationDbContext _context;
  private const string UploadsFolder = "wwwroot/uploads";

  public ForumService(ApplicationDbContext context)
  {
    _context = context;
  }

  public async Task<Forum> CreateForumAsync(ForumDto forumDto, IFormFile? screenshot)
  {
    var forum = new Forum
    {
      Id = Guid.NewGuid(),
      Topic = forumDto.Topic,
      DiscussionQuestion = forumDto.DiscussionQuestion,
      SubjectId = forumDto.SubjectId,
      CreatedAt = DateTime.Now
    };

    if (screenshot != null)
    {
      forum.Screenshot = await SaveScreenshotAsync(screenshot);
    }

    _context.Forums.Add(forum);
    await _context.SaveChangesAsync();
    return forum;
  }

  public async Task<List<ForumDto>> GetAllForumsAsync()
  {
    return await _context.Forums
      .Include(f => f.Subject)
      .Select(x => new ForumDto()
      {
        Id = x.Id,
        Topic = x.Topic,
        DiscussionQuestion = x.DiscussionQuestion,
        CreatedAt = x.CreatedAt,
        SubjectId = x.SubjectId,
        Screenshot = x.Screenshot
      })
      .ToListAsync();
  }

  public async Task<ForumDto?> GetForumByIdAsync(Guid id)
  {
    return await _context.Forums
      .Include(f => f.Subject)
      .Where(f => f.Id == id)
      .Select(x => new ForumDto()
      {
        Topic = x.Topic,
        DiscussionQuestion = x.DiscussionQuestion,
        CreatedAt = x.CreatedAt,
        SubjectId = x.SubjectId,
        Screenshot = x.Screenshot
      }).FirstOrDefaultAsync();
  }

  public async Task<bool> UpdateForumAsync(Forum forum, IFormFile? screenshot)
  {
    var existingForum = await _context.Forums.FindAsync(forum.Id);
    if (existingForum == null)
      return false;

    existingForum.Topic = forum.Topic;
    existingForum.DiscussionQuestion = forum.DiscussionQuestion;
    existingForum.SubjectId = forum.SubjectId;

    if (screenshot != null)
    {
      // Delete the old screenshot if it exists
      if (!string.IsNullOrEmpty(existingForum.Screenshot) && File.Exists(existingForum.Screenshot))
      {
        File.Delete(existingForum.Screenshot);
      }

      // Save the new screenshot
      existingForum.Screenshot = await SaveScreenshotAsync(screenshot);
    }
    else if (forum.Screenshot == null && !string.IsNullOrEmpty(existingForum.Screenshot))
    {
      // If the screenshot is explicitly set to null, delete the existing one
      if (File.Exists(existingForum.Screenshot))
      {
        File.Delete(existingForum.Screenshot);
      }
      existingForum.Screenshot = null;
    }

    _context.Forums.Update(existingForum);
    await _context.SaveChangesAsync();
    return true;
  }

  public async Task<bool> DeleteForumAsync(Guid id)
  {
    var forum = await _context.Forums.FindAsync(id);
    if (forum == null)
      return false;

    // Delete the screenshot if it exists
    if (!string.IsNullOrEmpty(forum.Screenshot) && File.Exists(forum.Screenshot))
    {
      File.Delete(forum.Screenshot);
    }

    _context.Forums.Remove(forum);
    await _context.SaveChangesAsync();
    return true;
  }

  private async Task<string> SaveScreenshotAsync(IFormFile screenshot)
  {
    var fileName = $"{Guid.NewGuid()}_{screenshot.FileName}";
    var filePath = Path.Combine(UploadsFolder, fileName);

    Directory.CreateDirectory(UploadsFolder);
    using (var stream = new FileStream(filePath, FileMode.Create))
    {
      await screenshot.CopyToAsync(stream);
    }

    return filePath;
  }
}
