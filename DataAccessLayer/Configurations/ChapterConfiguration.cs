using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
{
  public void Configure(EntityTypeBuilder<Chapter> builder)
  {
    builder
        .Property(c => c.ChapterTitle)
        .HasMaxLength(200)
        .IsRequired();

    builder
        .Property(c => c.ChapterNumber)
        .IsRequired();

    builder
        .HasOne(c => c.Term)
        .WithMany(t => t.Chapters)
        .HasForeignKey(c => c.TermId);
  }
}
