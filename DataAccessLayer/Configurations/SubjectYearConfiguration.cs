using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class SubjectYearConfiguration : IEntityTypeConfiguration<SubjectYear>
{
  public void Configure(EntityTypeBuilder<SubjectYear> builder)
  {
    builder.HasKey(ys => new { ys.YearId, ys.SubjectId });

    builder
        .HasOne(ys => ys.Year)
        .WithMany(g => g.SubjectYears)
        .HasForeignKey(ys => ys.YearId);

    builder
        .HasOne(ys => ys.Subject)
        .WithMany(s => s.SubjectYears)
        .HasForeignKey(ys => ys.SubjectId);
  }
}
