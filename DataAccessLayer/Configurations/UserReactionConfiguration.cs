using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class UserReactionConfiguration : IEntityTypeConfiguration<UserReaction>
{
  public void Configure(EntityTypeBuilder<UserReaction> builder)
  {
    builder.HasKey(ur => ur.Id);

    // Relationship to ApplicationUser
    builder
        .HasOne(ur => ur.User)
        .WithMany(u => u.UserReactions)
        .HasForeignKey(ur => ur.UserId)
        .OnDelete(DeleteBehavior.Restrict); // No cascade delete on user

    // Relationship to Comment
    builder
        .HasOne(ur => ur.Comment)
        .WithMany(c => c.UserReactions)
        .HasForeignKey(ur => ur.CommentId)
        .OnDelete(DeleteBehavior.Cascade); // Allow cascading delete on comment
  }
}
