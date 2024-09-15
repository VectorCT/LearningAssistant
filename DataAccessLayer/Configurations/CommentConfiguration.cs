using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
  public void Configure(EntityTypeBuilder<Comment> builder)
  {
    builder.HasKey(c => c.Id);

    // Relationship to Forum
    builder
        .HasOne(c => c.Forum)
        .WithMany(f => f.Comments)
        .HasForeignKey(c => c.ForumId)
        .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade when forum is deleted

    // Relationship to ApplicationUser
    builder
        .HasOne(c => c.User)
        .WithMany(u => u.Comments)
        .HasForeignKey(c => c.UserId)
        .OnDelete(DeleteBehavior.NoAction); // Prevent cascade delete for user

    // Self-referencing relationship for replies
    builder
        .HasOne(c => c.ParentComment)
        .WithMany(c => c.Replies)
        .HasForeignKey(c => c.ParentCommentId)
        .OnDelete(DeleteBehavior.NoAction); // Prevent cyclic deletion

    // Relationship with UserReaction
    builder
        .HasMany(c => c.UserReactions)
        .WithOne(ur => ur.Comment)
        .HasForeignKey(ur => ur.CommentId)
        .OnDelete(DeleteBehavior.Cascade); // Allow cascade delete for reactions when comment is deleted

    builder
        .Property(c => c.CommentText)
        .HasMaxLength(1000)
        .IsRequired();

    builder
        .Property(c => c.CreatedAt)
        .HasDefaultValueSql("GETDATE()");
  }
}
