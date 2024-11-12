using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
  public class Subject
  {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PrescribedTextBook { get; set; } = string.Empty;
    public string PrescribedTextBookFileUrl { get; set; } = string.Empty;
    public string SubjectImageUrl {  get; set; } = string.Empty;
    public string SubjectDescription { get; set; } = string.Empty;
    public List<AdditionalTextBook> AdditionalTextBooks { get; set; } = [];
    public List<Chapter> Chapters { get; set; } = [];
    public List<VideoTutorial> VideoTutorials { get; set; } = [];
    public List<TextbookFile> TextbookFiles { get; set; } = [];
    [JsonIgnore]
    public List<GradeSubject> GradeSubjects { get; set; } = [];
    public List<PastPaper> PastPapers { get; set; } = [];
    public List<Forum> Forums { get; set; } = [];
    [JsonIgnore]
    public List<SubjectYear> SubjectYears { get; set; } = [];
  }
}
