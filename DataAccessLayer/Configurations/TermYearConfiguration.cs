using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.Configurations;

public class TermYearConfiguration : IEntityTypeConfiguration<TermYear>
{
  public void Configure(EntityTypeBuilder<TermYear> builder)
  {
    builder.HasKey(ty => new { ty.TermId, ty.YearId });

    builder.HasOne(ty => ty.Term)
           .WithMany(t => t.TermYears)
           .HasForeignKey(ty => ty.TermId)
           .OnDelete(DeleteBehavior.Cascade);

    builder.HasOne(ty => ty.Year)
           .WithMany(y => y.TermYears)
           .HasForeignKey(ty => ty.YearId)
           .OnDelete(DeleteBehavior.Cascade);
  }
}
