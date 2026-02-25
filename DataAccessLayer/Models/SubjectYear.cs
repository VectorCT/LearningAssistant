namespace DataAccessLayer.Models;

public class SubjectYear
{
  public Guid Id { get; set; }
  public Guid SubjectId { get; set; }
  public Guid YearId { get; set; }
  public Subject? Subject { get; set; }
  public Year? Year { get; set; }
}
