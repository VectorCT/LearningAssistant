using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations
{
  public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
  {
    public void Configure(EntityTypeBuilder<Chapter> builder)
    {
      builder.Property(c => c.ChapterTitle)
             .HasMaxLength(200)
             .IsRequired();
      builder.Property(c => c.Description)
             .HasMaxLength(500)
             .IsRequired();

      builder.Property(c => c.ChapterNumber)
             .IsRequired();

      builder.HasOne(c => c.Term)
             .WithMany(t => t.Chapters)
             .HasForeignKey(c => c.TermId);

      builder.HasMany(c => c.Sections)
             .WithOne(s => s.Chapter)
             .HasForeignKey(s => s.ChapterId);
    }
  }
}
