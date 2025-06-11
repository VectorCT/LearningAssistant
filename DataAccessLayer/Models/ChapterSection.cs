using DataAccessLayer.Models.Enums;

namespace DataAccessLayer.Models;

public class ChapterSection
{
  public Guid Id { get; set; }
  public Guid ChapterId { get; set; }
  public Chapter Chapter { get; set; }

  public SectionType Type { get; set; }         // Title, Subtitle, Paragraph, Image, etc.
  public string Content { get; set; }           // Text or image URL depending on the type
  public int Order { get; set; }
  public Guid? ParentSectionId { get; set; }
  public ChapterSection? ParentSection { get; set; }
  public ICollection<ChapterSection> ChildSections { get; set; }

}