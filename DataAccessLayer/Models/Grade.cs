using System.Text.Json.Serialization;

namespace DataAccessLayer.Models;

public class Grade
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
  public DateTime? ModifiedAt { get; set; }
  public string? CreatedBy { get; set; }

  [JsonIgnore]
  public List<GradeSubject> GradeSubjects { get; set; } = [];
}
