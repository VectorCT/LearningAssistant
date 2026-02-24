namespace DataAccessLayer.Models;

public class MultipleChoiceAnswer : Answer
{
  public List<string> Options { get; set; } = []; // 4 or 5 options for multiple choice
  public string CorrectOption { get; set; } = string.Empty;

  public string Explanation { get; set; } = string.Empty;  // Explanation for correct/incorrect options
}

