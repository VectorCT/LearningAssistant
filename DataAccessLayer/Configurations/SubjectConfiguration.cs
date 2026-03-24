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

      builder
        .Property(s => s.SubjectDescription)
        .HasMaxLength(255)
        .IsRequired();

      builder
        .Property(s => s.PrescribedTextBookFileUrl)
        .HasMaxLength(500)
        .IsRequired();

      builder
        .Property(s => s.SubjectImageUrl)
        .HasMaxLength(500)
        .IsRequired();

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
          .HasMany(s => s.Forums)
          .WithOne(p => p.Subject)
          .HasForeignKey(p => p.SubjectId);

      // Seed data removed - let crawler populate subjects
    }
  }
}
