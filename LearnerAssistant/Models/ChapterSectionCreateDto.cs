using DataAccessLayer.Models.Enums;

namespace LearnerAssistant.Models;

public class ChapterSectionCreateDto
{
  public Guid Id { get; set; }
  public Guid ChapterId { get; set; }

  // Internal enum (used by backend), not shown in form
  public SectionType Type { get; set; }

  public string Content { get; set; }
  public int Order { get; set; }
  public Guid? ParentSectionId { get; set; }

  // For image uploads only
  public IFormFile? Image { get; set; }
}
