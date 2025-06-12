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

      // Example seed data for Chapter
      var chapterId = Guid.Parse("11111111-1111-1111-1111-111111111111");
      var termId = Guid.Parse("AA10883B-B521-4C82-8CF5-7DFB4215EBE4");
      builder.HasData(new Chapter
      {
        Id = chapterId,
        SubjectId = Guid.Parse("5A5DA2F4-F649-4994-95B1-228B82E9D98C"),
        TermId = termId,
        ChapterNumber = 1,
        ChapterTitle = "Introduction to Biology",
        Description = "Basic concepts of biology."
      });
    }
  }
}
