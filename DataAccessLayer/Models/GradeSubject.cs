
namespace DataAccessLayer.Models;

public class GradeSubject
{
  public Guid Id { get; set; }
  public Guid GradeId { get; set; }
  public Grade? Grade { get; set; }

  public int SubjectId { get; set; }
  public Subject? Subject { get; set; }
}
