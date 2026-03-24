namespace DataAccessLayer.Models;

public class WrittenAnswer : Answer
{
    // For written/open-response questions, the Description inherited from Answer
    // contains the model answer or marking scheme
    
    // Optional: Keywords that should appear in student's answer
    public string? KeyConcepts { get; set; }
    
    // Optional: Marks breakdown
    public int? MaxMarks { get; set; }
}
