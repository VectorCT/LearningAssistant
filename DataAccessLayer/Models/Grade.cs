namespace DataAccessLayer.Models;

public class Grade
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public List<GradeSubject> GradeSubjects { get; set; } = [];
}
