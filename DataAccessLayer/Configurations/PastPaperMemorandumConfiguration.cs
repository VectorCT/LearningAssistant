using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class PastPaperMemorandumConfiguration : IEntityTypeConfiguration<PastPaperMemorandum>
{
  public void Configure(EntityTypeBuilder<PastPaperMemorandum> builder)
  {
    builder.HasKey(ppm => ppm.Id);

    builder
        .HasOne(ppm => ppm.PastPaper)
        .WithMany(p => p.PastPaperMemorandums)
        .HasForeignKey(ppm => ppm.PastPaperId)
        .OnDelete(DeleteBehavior.Cascade);

    builder
        .HasOne(ppm => ppm.PastMemorandum)
        .WithMany(m => m.PastPaperMemorandums)
        .HasForeignKey(ppm => ppm.PastMemorandumId)
        .OnDelete(DeleteBehavior.Cascade);
  }
}
