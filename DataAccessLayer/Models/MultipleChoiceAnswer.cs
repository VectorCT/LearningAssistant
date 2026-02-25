namespace DataAccessLayer.Models;

public class MultipleChoiceAnswer : Answer
{
  public string? Options { get; set; }
  public string? CorrectOption { get; set; }

  public string? Explanation { get; set; }  // Explanation for correct/incorrect options
}

