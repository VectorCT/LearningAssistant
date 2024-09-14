using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class VideoTutorialConfiguration : IEntityTypeConfiguration<VideoTutorial>
{
  public void Configure(EntityTypeBuilder<VideoTutorial> builder)
  {
    builder
        .Property(v => v.VideoName)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .Property(v => v.VideoPath)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .HasOne(v => v.Subject)
        .WithMany(s => s.VideoTutorials)
        .HasForeignKey(v => v.SubjectId);
  }
}
