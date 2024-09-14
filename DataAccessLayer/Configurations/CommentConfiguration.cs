using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
  public void Configure(EntityTypeBuilder<Comment> builder)
  {
    builder
        .Property(c => c.CommentText)
        .HasMaxLength(1000)
        .IsRequired();

    builder
        .Property(c => c.CreatedAt)
        .HasDefaultValueSql("GETDATE()");

    builder
        .HasOne(c => c.User)
        .WithMany(u => u.Comments)
        .HasForeignKey(c => c.UserId);
  }
}
