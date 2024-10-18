using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class PastPaperConfiguration : IEntityTypeConfiguration<PastPaper>
{
  public void Configure(EntityTypeBuilder<PastPaper> builder)
  {
    builder
        .Property(pp => pp.FileName)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .Property(pp => pp.FilePath)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .HasOne(pp => pp.Subject)
        .WithMany(s => s.PastPapers)
        .HasForeignKey(pp => pp.SubjectId);
    builder
        .HasOne(c => c.Year)
        .WithMany(t => t.PastPapers)
        .HasForeignKey(c => c.YearId);
  }
}
