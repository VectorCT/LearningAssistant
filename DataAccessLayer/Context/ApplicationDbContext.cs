
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
  public DbSet<GradeSubject> GradeSubjects { get; set; }
  public DbSet<Forum> Forums { get; set; }
  public DbSet<Comment> Comments { get; set; }
  public DbSet<Term> Terms { get; set; }
  public DbSet<Chapter> Chapters { get; set; }
  public DbSet<PastPaper> PastPapers { get; set; }
  public DbSet<PastMemorandum> PastMemorandums { get;set; }
  public DbSet<PastPaperMemorandum> PastPaperMemorandums { get; set; }
  public DbSet<TextbookFile> TextbookFiles { get; set; }
  public DbSet<AdditionalTextBook> AdditionalTextBooks { get; set; }
  public DbSet<UserReaction> UserReactions { get; set; }
  public DbSet<VideoTutorial> VideoTutorials { get; set; }

  protected override void OnModelCreating(
      ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(
        Assembly.GetExecutingAssembly());
  }
}
