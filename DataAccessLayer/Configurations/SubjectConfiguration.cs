using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations
{
  public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
  {
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
      builder
          .Property(s => s.Name)
          .HasMaxLength(100)
          .IsRequired();

      builder
          .Property(s => s.PrescribedTextBook)
          .HasMaxLength(200);

      // Relationships
      builder
          .HasMany(s => s.AdditionalTextBooks)
          .WithOne(at => at.Subject)
          .HasForeignKey(at => at.SubjectId);

      builder
          .HasMany(s => s.Chapters)
          .WithOne(c => c.Subject)
          .HasForeignKey(c => c.SubjectId);

      builder
          .HasMany(s => s.VideoTutorials)
          .WithOne(v => v.Subject)
          .HasForeignKey(v => v.SubjectId);

      builder
          .HasMany(s => s.PastPapers)
          .WithOne(p => p.Subject)
          .HasForeignKey(p => p.SubjectId);

      builder
          .HasMany(s => s.PastMemorandums)
          .WithOne(p => p.Subject)
          .HasForeignKey(p => p.SubjectId);

      // Seed data for subjects (optional)
      //builder.HasData(
      //    new Subject { Id = 1, Name = "Mathematics", PrescribedTextBook = "MathBook.pdf" },
      //    new Subject { Id = 2, Name = "Science", PrescribedTextBook = "ScienceBook.pdf" }
      //);
    }
  }
}
