using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface IChapterSectionService
{
  Task<IEnumerable<ChapterSectionDto>> GetAllByChapterAsync(Guid chapterId);
  Task<ChapterSectionDto> GetByIdAsync(Guid id);
  Task<ChapterSectionCreateDto> CreateAsync(ChapterSectionCreateDto sectionDto);
  Task<ChapterSectionCreateDto> UpdateAsync(ChapterSectionDto sectionDto);
  Task<bool> DeleteAsync(Guid id);
}
