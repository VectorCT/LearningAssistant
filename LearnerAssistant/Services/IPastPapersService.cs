using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface IPastPapersService
{
  Task<IReadOnlyList<PastPaperDto>> GetPastPapersAsync();
  Task<IReadOnlyList<PastPaperDto>> GetPastPapersBySubject(Guid subjectId);
  Task<PastPaper> UploadPastPaper(PastPaperDto request);
  Task<FileDownloadDto> DownloadPastPaper(Guid id);
}
