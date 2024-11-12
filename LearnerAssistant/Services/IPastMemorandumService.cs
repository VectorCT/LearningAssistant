using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface IPastMemorandumService
{
  Task<IReadOnlyList<PastMemoDto>> GetPastMemosAsync();
  Task<IReadOnlyList<PastMemoDto>> GetPastMemosBySubject(Guid subjectId);
  Task<PastMemorandum> UploadPastMemo(PastMemoDto request);
  Task<FileDownloadDto> DownloadPastPaper(Guid id);
}
