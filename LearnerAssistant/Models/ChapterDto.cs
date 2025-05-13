using DataAccessLayer.Models;

namespace LearnerAssistant.Models;

public class ChapterDto
{
  public Guid SubjectId { get; set; }
  public Guid TermId { get; set; }
  public int ChapterNumber { get; set; }
  public string ChapterTitle { get; set; }
  public string Description { get; set; }
  public List<ChapterSectionDto> Sections { get; set; } = [];
}
