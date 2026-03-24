using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccessLayer.Context;

public class ApplicationDbContext(
  DbContextOptions<ApplicationDbContext> options
  ) : IdentityDbContext<ApplicationUser>(options)
{
  public DbSet<Grade> Grades { get; set; }
  public DbSet<Subject> Subjects { get; set; }
  public DbSet<SubjectYear> SubjectYears { get; set; }
  public DbSet<GradeSubject> GradeSubjects { get; set; }
  public DbSet<Forum> Forums { get; set; }
  public DbSet<Comment> Comments { get; set; }
  public DbSet<Term> Terms { get; set; }
  public DbSet<Year> Years { get; set; }
  public DbSet<Chapter> Chapters { get; set; }
  public DbSet<ChapterSection> ChapterSections { get; set; }
  public DbSet<PastPaper> PastPapers { get; set; }
  public DbSet<PastMemorandum> PastMemorandums { get; set; }
  public DbSet<PastPaperMemorandum> PastPaperMemorandums { get; set; }
  public DbSet<TextbookFile> TextbookFiles { get; set; }
  public DbSet<AdditionalTextBook> AdditionalTextBooks { get; set; }
  public DbSet<UserReaction> UserReactions { get; set; }
  public DbSet<VideoTutorial> VideoTutorials { get; set; }
  public DbSet<TermYear> TermYears { get; set; }
  public DbSet<QuestionType> QuestionTypes { get; set; }
  public DbSet<Question> Questions { get; set; }
  public DbSet<Answer> Answers { get; set; }
  public DbSet<MultipleChoiceAnswer> MultipleChoices { get; set; }
  public DbSet<TrueFalseAnswer> TrueFalseAnswers { get; set; }
  public DbSet<WrittenAnswer> WrittenAnswers { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(
        Assembly.GetExecutingAssembly());

    // Seed data removed - let crawler populate the database

    // Indexes configured per new DB schema
    modelBuilder.Entity<Chapter>()
                .HasIndex(c => new { c.SubjectId, c.TermId });

    modelBuilder.Entity<Question>()
                .HasIndex(q => new { q.ChapterId, q.QuestionTypeId });

    modelBuilder.Entity<Comment>()
                .HasIndex(c => new { c.ForumId, c.CreatedAt });
  }
}
