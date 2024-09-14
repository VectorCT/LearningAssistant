using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class TextbookFileConfiguration : IEntityTypeConfiguration<TextbookFile>
{
  public void Configure(EntityTypeBuilder<TextbookFile> builder)
  {
    builder.HasKey(t => t.Id);

    builder
        .Property(t => t.FileName)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .Property(t => t.FilePath)
        .HasMaxLength(500)
        .IsRequired();

    builder
        .HasOne(t => t.Subject)
        .WithMany(s => s.TextbookFiles)
        .HasForeignKey(t => t.SubjectId);
  }
}
