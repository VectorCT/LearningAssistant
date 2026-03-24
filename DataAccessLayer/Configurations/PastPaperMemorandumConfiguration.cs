using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class PastPaperMemorandumConfiguration : IEntityTypeConfiguration<PastPaperMemorandum>
{
    public void Configure(EntityTypeBuilder<PastPaperMemorandum> builder)
    {
        builder.ToTable("PastPaperMemorandums");

        builder.HasKey(ppm => ppm.Id);

        builder
            .HasOne(ppm => ppm.PastPaper)
            .WithMany()
            .HasForeignKey(ppm => ppm.PastPaperId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(ppm => ppm.PastMemorandum)
            .WithMany()
            .HasForeignKey(ppm => ppm.PastMemorandumId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
