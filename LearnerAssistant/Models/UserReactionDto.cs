using System;

namespace LearnerAssistant.Models;

public class UserReactionDto
{
  public Guid Id { get; set; }
  public string UserId { get; set; } = string.Empty;
  public bool Upvote { get; set; }
  public bool Like { get; set; }
}
