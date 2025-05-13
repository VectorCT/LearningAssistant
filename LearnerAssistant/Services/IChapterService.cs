using DataAccessLayer.Models;
using LearnerAssistant.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
  public interface IChapterService
  {
    Task<IEnumerable<ChapterDto>> GetAllChaptersAsync();
    Task<Chapter> GetChapterByIdAsync(Guid id);
    Task<Chapter> CreateChapterAsync(ChapterDto chapter);
    Task<Chapter> UpdateChapterAsync(Chapter chapter);
    Task<bool> DeleteChapterAsync(Guid id);
  }
}
