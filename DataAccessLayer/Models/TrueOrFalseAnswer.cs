namespace DataAccessLayer.Models;

public class TrueFalseAnswer : Answer
{
  public bool? IsTrue { get; set; }  // True or False

  public string? Explanation { get; set; }  // Explanation for why the answer is true/false
}
