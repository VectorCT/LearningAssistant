using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface IChapterSectionService
{
  Task<IEnumerable<ChapterSectionCreateDto>> GetAllByChapterAsync(Guid chapterId);
  Task<ChapterSectionCreateDto> GetByIdAsync(Guid id);
  Task<ChapterSectionCreateDto> CreateAsync(ChapterSectionCreateDto sectionDto);
  Task<ChapterSectionCreateDto> UpdateAsync(ChapterSectionDto sectionDto);
  Task<bool> DeleteAsync(Guid id);
}
