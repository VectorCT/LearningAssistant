using System;
using System.Collections.Generic;

namespace LearnerAssistant.Models;

public class CommentDto
{
  public Guid Id { get; set; }
  public Guid ForumId { get; set; }
  public string UserId { get; set; } = string.Empty;
  public string UserName { get; set; } = string.Empty;
  public string CommentText { get; set; } = string.Empty;
  public Guid? ParentCommentId { get; set; }
  public List<CommentDto> Replies { get; set; } = new();
  public List<UserReactionDto> UserReactions { get; set; } = new();
  public int Upvotes { get; set; }
  public int Likes { get; set; }
  public DateTime CreatedAt { get; set; }
}
