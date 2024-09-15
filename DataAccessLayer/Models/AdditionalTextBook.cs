using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
  public class AdditionalTextBook
  {
    public Guid Id { get; set; }
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }
    public string BookTitle { get; set; } = string.Empty;
    public string BookFilePath { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
  }
}
