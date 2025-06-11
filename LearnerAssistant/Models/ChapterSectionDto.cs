using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;

namespace LearnerAssistant.Models;

public class ChapterSectionDto
{
  public Guid Id { get; set; }
  public Guid ChapterId { get; set; }
  public SectionType Type { get; set; }
  public string SectionType { get; set; }
  public string Content { get; set; } // Only used if not image
  public int Order { get; set; }
  public IFormFile Image { get; set; } // Only used if type == Image
  public Guid? ParentSectionId { get; set; }
  public ChapterSectionDto ParentSection { get; set; }
  public ICollection<ChapterSectionDto> ChildSections { get; set; }
}
