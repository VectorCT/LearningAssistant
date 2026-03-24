using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class PastMemorandumConfiguration : IEntityTypeConfiguration<PastMemorandum>
{
  public void Configure(EntityTypeBuilder<PastMemorandum> builder)
  {
    builder
        .Property(pm => pm.FileName)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .Property(pm => pm.FilePath)
        .HasMaxLength(500)
        .IsRequired();

    builder
        .Property(pm => pm.PastPaperId)
        .IsRequired(false);

    builder
        .HasOne(pm => pm.PastPaper)
        .WithOne(p => p.PastMemorandum)
        .HasForeignKey<PastMemorandum>(pm => pm.PastPaperId)
        .IsRequired(false);
  }
}
