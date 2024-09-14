using System.Xml.Linq;

namespace DataAccessLayer.Models;

public class Forum
{
  public Guid Id { get; set; }
  public string Topic { get; set; } = string.Empty;
  public string DiscussionQuestion { get; set; } = string.Empty;
  public List<Comment> Comments { get; set; }
}
