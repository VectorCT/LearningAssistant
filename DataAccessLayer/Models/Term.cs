namespace DataAccessLayer.Models;

public class Term
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Duration { get; set; } = string.Empty;
  public List<Chapter> Chapters { get; set; } = [];
}
