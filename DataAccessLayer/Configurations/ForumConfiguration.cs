using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class ForumConfiguration : IEntityTypeConfiguration<Forum>
{
  public void Configure(EntityTypeBuilder<Forum> builder)
  {
    builder
        .Property(f => f.Topic)
        .HasMaxLength(200)
        .IsRequired();

    builder
        .Property(f => f.DiscussionQuestion)
        .HasMaxLength(500)
        .IsRequired();

    builder
        .HasMany(f => f.Comments)
        .WithOne(c => c.Forum)
        .HasForeignKey(c => c.ForumId);
  }
}
