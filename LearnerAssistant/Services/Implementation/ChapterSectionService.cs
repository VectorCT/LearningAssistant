using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerAssistant.Services.Implementation;
public class ChapterSectionService(ApplicationDbContext context) : IChapterSectionService
{
  private readonly ApplicationDbContext _context = context;

  public async Task<ChapterSectionCreateDto> CreateAsync(ChapterSectionCreateDto dto)
  {
    string content;
    if (dto.Type == SectionType.Image)
    {
      if (dto.Image == null || dto.Image.Length == 0)
        throw new Exception("Image file is required for image sections.");

      var uploadsFolder = Path.Combine("wwwroot", "uploads");
      Directory.CreateDirectory(uploadsFolder);

      var fileName = Guid.NewGuid() + Path.GetExtension(dto.Image.FileName);
      var filePath = Path.Combine(uploadsFolder, fileName);

      using (var stream = new FileStream(filePath, FileMode.Create))
      {
        await dto.Image.CopyToAsync(stream);
      }

      content = $"/uploads/{fileName}";
    }
    else
    {
      content = dto.Content;
    }

    var section = new ChapterSection
    {
      Id = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id,
      ChapterId = dto.ChapterId,
      Type = dto.Type,
      Content = content,
      Order = dto.Order,
      ParentSectionId = dto.ParentSectionId,
      ParentSection = null
    };

    await _context.AddAsync(section);
    await _context.SaveChangesAsync();

    return MapToDto(section);
  }


  public async Task<ChapterSectionCreateDto> UpdateAsync(ChapterSectionDto dto)
  {
    var section = await _context.Set<ChapterSection>().FindAsync(dto.Id);
    if (section == null) return null;

    section.Type = dto.Type;
    section.Order = dto.Order;

    if (dto.Type == SectionType.Image)
    {
      if (dto.Image != null && dto.Image.Length > 0)
      {
        var uploadsFolder = Path.Combine("wwwroot", "uploads");
        Directory.CreateDirectory(uploadsFolder);

        var fileName = Guid.NewGuid() + Path.GetExtension(dto.Image.FileName);
        var filePath = Path.Combine(uploadsFolder, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
          await dto.Image.CopyToAsync(stream);
        }

        section.Content = $"/uploads/{fileName}";
      }
    }
    else
    {
      section.Content = dto.Content;
    }

    _context.Update(section);
    await _context.SaveChangesAsync();

    return MapToDto(section);
  }

  public async Task<bool> DeleteAsync(Guid id)
  {
    var entity = await _context.Set<ChapterSection>().FindAsync(id);
    if (entity == null) return false;

    _context.Remove(entity);
    await _context.SaveChangesAsync();
    return true;
  }

  public async Task<ChapterSectionCreateDto?> GetByIdAsync(Guid id)
  {
    var entity = await _context.Set<ChapterSection>().FindAsync(id);
    return entity != null ? MapToDto(entity) : null;
  }

  public async Task<IEnumerable<ChapterSectionCreateDto>> GetAllByChapterAsync(Guid chapterId)
  {
    var sections = await _context.ChapterSections
        .Where(s => s.ChapterId == chapterId)
        .OrderBy(s => s.Order)
        .ToListAsync();

    var sectionDict = sections.ToDictionary(s => s.Id);

    foreach (var section in sections)
    {
        if (section.ParentSectionId.HasValue && sectionDict.TryGetValue(section.ParentSectionId.Value, out var parent))
        {
            parent.ChildSections.Add(section);
        }
    }

    // Top-level sections (no parent)
    var rootSections = sections.Where(s => s.ParentSectionId == null).ToList();

    return rootSections.Select(MapToDto);
  }

  private ChapterSectionCreateDto MapToDto(ChapterSection section) => new()
  {
    Id = section.Id,
    ChapterId = section.ChapterId,
    Type = section.Type,
    Content = section.Content,
    Order = section.Order
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
        SectionType = section.Type.ToString(),
        Content = section.Content,
        Order = section.Order,
        ParentSectionId = section.ParentSectionId,
        ChildSections = childrenLookup.TryGetValue(section.Id, out var children)
            ? children.Select(child => MapToDto(child, childrenLookup)).ToList()
            : []
    };
  }

  private static string MapToDatabaseFormat(SectionTypeLookupEnum sectionType)
  {
    switch (sectionType)
    {
      case SectionTypeLookupEnum.Title:
        return "Title";
      case SectionTypeLookupEnum.Subtitle:
        return "Subtitle";
      case SectionTypeLookupEnum.Paragraph:
        return "Paragraph";
      case SectionTypeLookupEnum.Image:
        return "Image";
      default:
        throw new ArgumentOutOfRangeException();
    }
  }
}