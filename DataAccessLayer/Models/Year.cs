using DataAccessLayer.Models;

public class Year
{
  public Guid Id { get; set; }
  public int YearNumber { get; set; }
  public List<TermYear> TermYears { get; set; } = [];
}
