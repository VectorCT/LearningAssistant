using System.Xml.Linq;

namespace DataAccessLayer.Models;

public class Forum
{
  public Guid Id { get; set; }
  public string Topic { get; set; } = string.Empty;
  public string DiscussionQuestion { get; set; } = string.Empty;
  public DateTime CreatedAt { get; set; }
  public Guid SubjectId { get; set; }
  public Subject? Subject { get; set; }
  public List<Comment> Comments { get; set; }
}
