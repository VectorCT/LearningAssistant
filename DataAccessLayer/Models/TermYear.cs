namespace DataAccessLayer.Models;

public class TermYear
{
  public Guid TermId { get; set; }
  public Term Term { get; set; } = null!;

  public Guid YearId { get; set; }
  public Year Year { get; set; } = null!;
}

