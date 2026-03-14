using DataAccessLayer.Models;
using LearnerAssistant.Models;

namespace LearnerAssistant.Services;

public interface IVideoTutorialService
{
  Task<IReadOnlyList<VideoTutorialDto>> GetAllVideoTutorialsAsync();
  Task<VideoTutorialDto?> GetVideoTutorialByIdAsync(Guid id);
  Task<IReadOnlyList<VideoTutorialDto>> GetVideoTutorialsBySubjectAsync(Guid subjectId);
  Task<VideoTutorial> UploadVideoTutorialAsync(VideoTutorialDto request);
  Task<FileDownloadDto> DownloadVideoTutorialAsync(Guid id);
  Task<bool> DeleteVideoTutorialAsync(Guid id);
}
