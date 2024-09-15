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

    // Defining foreign key relationship with Year
    builder
            .HasMany(t => t.TermYears)
            .WithOne(ty => ty.Term)
            .HasForeignKey(ty => ty.TermId)
            .OnDelete(DeleteBehavior.Cascade);

    // Seed Data (Optional)
    builder.HasData(
        new Term { Id = Guid.NewGuid(), Name = "Term 1", Duration = "Jan - Mar" },
        new Term { Id = Guid.NewGuid(), Name = "Term 2", Duration = "Apr - Jun" },
        new Term { Id = Guid.NewGuid(), Name = "Term 3", Duration = "Jul - Sep" },
        new Term { Id = Guid.NewGuid(), Name = "Term 4", Duration = "Oct - Dec" }
    );
  }
}
