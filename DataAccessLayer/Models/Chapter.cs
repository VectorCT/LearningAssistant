using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
  public class Chapter
  {
    public Guid Id { get; set; }
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }
    public Guid TermId { get; set; }
    public Term Term { get; set; }
    public int ChapterNumber { get; set; }
    public string Content { get; set; }
    public string ChapterTitle { get; set; }
    public ICollection<Question> Questions { get; set; } = [];
  }
}
