using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;
/// <summary>
/// Service for managing chapter sections.
/// </summary>
public class ChapterSectionService(ApplicationDbContext context) : IChapterSectionService
{
  private readonly ApplicationDbContext _context = context;
  private readonly string _uploadsPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

  /// <summary>
  /// Creates a new chapter section, handling optional image upload when type is Image.
  /// </summary>
  public async Task<ChapterSectionCreateDto> CreateAsync(ChapterSectionCreateDto dto)
  {
    string content = dto.Content;
    string? imageUrl = null;

    if (dto.Type == SectionType.Image)
    {
      if (dto.Image != null && dto.Image.Length > 0)
      {
        try
        {
          Directory.CreateDirectory(_uploadsPath);

          var fileName = Guid.NewGuid() + Path.GetExtension(dto.Image.FileName);
          var filePath = Path.Combine(_uploadsPath, fileName);

          using (var stream = new FileStream(filePath, FileMode.Create))
          {
            await dto.Image.CopyToAsync(stream);
          }

          imageUrl = $"/uploads/{fileName}";
        }
        catch (Exception ex)
        {
          // Log error but continue - don't fail the entire operation
          Console.WriteLine($"Error saving image: {ex.Message}");
          imageUrl = null;
        }
      }
      // Keep content as-is for captions; imageUrl stores the image path.
    }

    var section = new ChapterSection
    {
      Id = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id,
      ChapterId = dto.ChapterId,
      Type = dto.Type,
      Content = content,
      Image = imageUrl,
      Order = dto.Order,
      ParentSectionId = dto.ParentSectionId,
      ParentSection = null
    };

    await _context.AddAsync(section);
    await _context.SaveChangesAsync();

    return MapToCreateDto(section);
  }

  /// <summary>
  /// Updates an existing chapter section, including optional image replacement when type is Image.
  /// </summary>
  public async Task<ChapterSectionCreateDto> UpdateAsync(ChapterSectionDto dto)
  {
    var section = await _context.Set<ChapterSection>().FindAsync(dto.Id);
    if (section == null) return null;

    section.Type = dto.Type;
    section.Order = dto.Order;
    section.Content = dto.Content;

    if (dto.Type == SectionType.Image)
    {
      if (dto.Image != null && dto.Image.Length > 0)
      {
        try
        {
          Directory.CreateDirectory(_uploadsPath);

          var fileName = Guid.NewGuid() + Path.GetExtension(dto.Image.FileName);
          var filePath = Path.Combine(_uploadsPath, fileName);

          using (var stream = new FileStream(filePath, FileMode.Create))
          {
            await dto.Image.CopyToAsync(stream);
          }

          section.Image = $"/uploads/{fileName}";
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error saving image: {ex.Message}");
          section.Image = dto.ImageUrl;
        }
      }
      else
      {
        section.Image = dto.ImageUrl;
      }
    }
    else
    {
      section.Image = dto.ImageUrl;
    }

    _context.Update(section);
    await _context.SaveChangesAsync();

    return MapToCreateDto(section);
  }

  /// <summary>
  /// Deletes a chapter section by id.
  /// </summary>
  public async Task<bool> DeleteAsync(Guid id)
  {
    var entity = await _context.Set<ChapterSection>().FindAsync(id);
    if (entity == null) return false;

    _context.Remove(entity);
    await _context.SaveChangesAsync();
    return true;
  }

  /// <summary>
  /// Gets a chapter section by id including its hierarchical children.
  /// </summary>
  public async Task<ChapterSectionDto?> GetByIdAsync(Guid id)
  {
    var section = await _context.Set<ChapterSection>()
      .AsNoTracking()
      .FirstOrDefaultAsync(s => s.Id == id);

    if (section == null) return null;

    var allInChapter = await _context.ChapterSections
      .AsNoTracking()
      .Where(s => s.ChapterId == section.ChapterId)
      .OrderBy(s => s.Order)
      .ToListAsync();

    var childrenLookup = allInChapter
      .Where(s => s.ParentSectionId.HasValue)
      .GroupBy(s => s.ParentSectionId!.Value)
      .ToDictionary(g => g.Key, g => g.OrderBy(c => c.Order).ToList());

    return MapToDto(section, childrenLookup);
  }

  /// <summary>
  /// Gets all chapter sections for a chapter, returning only root sections populated with hierarchical children.
  /// </summary>
  public async Task<IEnumerable<ChapterSectionDto>> GetAllByChapterAsync(Guid chapterId)
  {
    var sections = await _context.ChapterSections
      .AsNoTracking()
      .Where(s => s.ChapterId == chapterId)
      .OrderBy(s => s.Order)
      .ToListAsync();

    var childrenLookup = sections
      .Where(s => s.ParentSectionId.HasValue)
      .GroupBy(s => s.ParentSectionId!.Value)
      .ToDictionary(g => g.Key, g => g.OrderBy(c => c.Order).ToList());

    var rootSections = sections
      .Where(s => s.ParentSectionId == null)
      .OrderBy(s => s.Order);

    return rootSections.Select(s => MapToDto(s, childrenLookup)).ToList();
  }
  private static ChapterSectionCreateDto MapToCreateDto(ChapterSection section) => new()
  {
    Id = section.Id,
    ChapterId = section.ChapterId,
    Type = section.Type,
    Content = section.Content,
    Image = null,
    Order = section.Order,
    ParentSectionId = section.ParentSectionId
  };

  private static ChapterSectionDto MapToDto(
    ChapterSection section,
    Dictionary<Guid, List<ChapterSection>> childrenLookup)
  {
    return new ChapterSectionDto
    {
      Id = section.Id,
      ChapterId = section.ChapterId,
      Type = section.Type,
      Content = section.Content,
      ImageUrl = section.Image,
      Order = section.Order,
      ParentSectionId = section.ParentSectionId,
      ChildSections = childrenLookup.TryGetValue(section.Id, out var children)
          ? children.Select(child => MapToDto(child, childrenLookup)).ToList()
          : []
    };
  }

  //private static string MapToDatabaseFormat(SectionTypeLookupEnum sectionType)
  //{
  //  switch (sectionType)
  //  {
  //    case SectionTypeLookupEnum.Title:
  //      return "Title";
  //    case SectionTypeLookupEnum.Subtitle:
  //      return "Subtitle";
  //    case SectionTypeLookupEnum.Paragraph:
  //      return "Paragraph";
  //    case SectionTypeLookupEnum.Image:
  //      return "Image";
  //    default:
  //      throw new ArgumentOutOfRangeException();
  //  }
  //}
}