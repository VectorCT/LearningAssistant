using DataAccessLayer.Models;
using System.Security.Cryptography.X509Certificates;

namespace LearnerAssistant.Models;

public class GradeDto
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public ICollection<SubjectDto> Subjects { get; set; } = [];
}
