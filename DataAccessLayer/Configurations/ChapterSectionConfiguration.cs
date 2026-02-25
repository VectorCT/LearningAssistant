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
           .IsRequired()
           .HasMaxLength(4000);

    builder.Property(s => s.Order)
           .IsRequired();

    builder.Property(s => s.Image)
           .HasMaxLength(1000);

    builder.HasOne(s => s.ParentSection)
       .WithMany(s => s.ChildSections)
       .HasForeignKey(s => s.ParentSectionId)
       .OnDelete(DeleteBehavior.Restrict);
  }
}
