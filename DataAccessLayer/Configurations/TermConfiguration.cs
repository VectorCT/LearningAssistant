using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class TermConfiguration : IEntityTypeConfiguration<Term>
{
  public void Configure(EntityTypeBuilder<Term> builder)
  {
    builder.HasKey(t => t.Id);

    builder.Property(t => t.Name)
           .HasMaxLength(100)
           .IsRequired();

    builder.Property(t => t.Duration)
           .IsRequired();

    builder
            .HasMany(t => t.TermYears)
            .WithOne(ty => ty.Term)
            .HasForeignKey(ty => ty.TermId)
            .OnDelete(DeleteBehavior.Cascade);

    // Seed data removed
  }
}
