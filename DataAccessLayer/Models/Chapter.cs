using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
  public class Chapter
  {
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public int TermId { get; set; }
    public Term Term { get; set; }
    public int ChapterNumber { get; set; }
    public string ChapterTitle { get; set; }
  }
}
