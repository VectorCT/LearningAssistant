
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class YearConfiguration : IEntityTypeConfiguration<Year>
{
  public void Configure(EntityTypeBuilder<Year> builder)
  {
    builder.HasKey(y => y.Id);

    builder.Property(y => y.YearNumber)
           .IsRequired();

    builder.HasMany(y => y.TermYears)
            .WithOne(ty => ty.Year)
            .HasForeignKey(ty => ty.YearId)
            .OnDelete(DeleteBehavior.Restrict);

    // Seeding some sample years
    builder.HasData(
        new Year { Id = Guid.NewGuid(), YearNumber = 2020 },
        new Year { Id = Guid.NewGuid(), YearNumber = 2021 },
        new Year { Id = Guid.NewGuid(), YearNumber = 2022 },
        new Year { Id = Guid.NewGuid(), YearNumber = 2023 },
        new Year { Id = Guid.NewGuid(), YearNumber = 2024 }
    );
  }
}
