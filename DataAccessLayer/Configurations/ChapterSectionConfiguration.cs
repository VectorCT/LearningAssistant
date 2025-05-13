using DataAccessLayer.Models;
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

  }
}
