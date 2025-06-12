using DataAccessLayer.Models;
using DataAccessLayer.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class ChapterSectionConfiguration : IEntityTypeConfiguration<ChapterSection>
{
  public void Configure(EntityTypeBuilder<ChapterSection> builder)
  {
    builder.Property(s => s.Type)
           .IsRequired();

    builder.Property(s => s.Content)
           .IsRequired();

    builder.Property(s => s.Order)
           .IsRequired();

    builder.HasOne(s => s.ParentSection)
       .WithMany(s => s.ChildSections)
       .HasForeignKey(s => s.ParentSectionId)
       .OnDelete(DeleteBehavior.Restrict);

    builder.HasData(
      new ChapterSection
      {
        Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
        ChapterId = Guid.Parse("11111111-1111-1111-1111-111111111111"), // Must match a seeded Chapter
        Type = SectionType.Title,
        Content = "What is Biology?",
        Order = 1,
        ParentSectionId = null
      },
      new ChapterSection
      {
        Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
        ChapterId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        Type = SectionType.Paragraph,
        Content = "Biology is the study of living organisms.",
        Order = 2,
        ParentSectionId = Guid.Parse("44444444-4444-4444-4444-444444444444")
      }
    );
  }
}
