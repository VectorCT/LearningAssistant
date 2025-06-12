using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;
using LearnerAssistant.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System.Diagnostics;

namespace Services.Implementations;

public class ChapterService(ApplicationDbContext context) : IChapterService
{
  private readonly ApplicationDbContext _context = context;

  public async Task<IEnumerable<ChapterDto>> GetAllChaptersAsync()
  {
    var chapters = await _context.Chapters
    .Include(c => c.Sections)
    .Select(c => new ChapterDto
    {
      ChapterNumber = c.ChapterNumber,
      ChapterTitle = c.ChapterTitle,
      SubjectId = c.SubjectId,
      TermId = c.TermId,
      Sections = c.Sections
            .Where(s => s.ParentSectionId == null)
            .OrderBy(s => s.Order)
            .Select(parent => new ChapterSectionDto
            {
              Id = parent.Id,
              ChapterId = parent.ChapterId,
              Content = parent.Content,
              SectionType = parent.Type.ToString(),
              Order = parent.Order,
              ChildSections = c.Sections
                    .Where(s => s.ParentSectionId == parent.Id)
                    .OrderBy(s => s.Order)
                    .Select(child => new ChapterSectionDto
                    {
                      Content = child.Content,
                      SectionType = child.Type.ToString(),
                      Order = child.Order
                    }).ToList()
            }).ToList()
    }).ToListAsync();

    return chapters;
  }


  public async Task<Chapter> GetChapterByIdAsync(Guid id) 
    => await _context.Set<Chapter>()
    .Include(c => c.Sections)
    .Include(c => c.Questions)
    .FirstOrDefaultAsync(c => c.Id == id);

  public async Task<Chapter> CreateChapterAsync(ChapterDto chapter)
  {
    var chapterSave = new Chapter
    {
      ChapterNumber = chapter.ChapterNumber,
      ChapterTitle = chapter.ChapterTitle,
      SubjectId = chapter.SubjectId,
      TermId = chapter.TermId,
      Description = chapter.Description,
    };
    await _context.AddAsync(chapterSave);
    await _context.SaveChangesAsync();
    return chapterSave;
  }

  public async Task<Chapter> UpdateChapterAsync(Chapter chapter)
  {
    _context.Set<Chapter>().Update(chapter);
    await _context.SaveChangesAsync();
    return chapter;
  }

  public async Task<bool> DeleteChapterAsync(Guid id)
  {
    var chapter = await _context.Set<Chapter>().FindAsync(id);
    if (chapter == null)
      return false;

    _context.Set<Chapter>().Remove(chapter);
    await _context.SaveChangesAsync();
    return true;
  }
  private static string MapToDatabaseFormat(SectionType sectionType)
  {
    switch (sectionType)
    {
      case SectionType.Title:
        return "Title";
      case SectionType.Subtitle:
        return "Subtitle";
      case SectionType.Paragraph:
        return "Paragraph";
      case SectionType.Image:
        return "Image";
      default:
        throw new ArgumentOutOfRangeException();
    }
  }
}
