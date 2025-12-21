using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;

namespace LearnerAssistant.Models;

public class ChapterSectionDto
{
  public Guid Id { get; set; }
  public Guid ChapterId { get; set; }

  // Internal enum (used by backend), not shown in form
  public SectionType Type { get; set; }
  public string Content { get; set; }           // Text content
  public string? ImageUrl { get; set; }         // Persisted image URL/path (nullable)
  public int Order { get; set; }
  public IFormFile? Image { get; set; }         // For upload when type == Image
  public Guid? ParentSectionId { get; set; }
  public ChapterSectionDto? ParentSection { get; set; }
  public ICollection<ChapterSectionDto> ChildSections { get; set; } = [];
}
