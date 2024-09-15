using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
  public void Configure(EntityTypeBuilder<Question> builder)
  {
    builder
        .Property(q => q.QuestionText)
        .HasMaxLength(500)  // Assuming a max length for the question text
        .IsRequired();

    builder
        .Property(q => q.PointValue)
        .IsRequired();

    builder
        .HasOne(q => q.Chapter)
        .WithMany(c => c.Questions)
        .HasForeignKey(q => q.ChapterId);

    builder
        .HasOne(q => q.QuestionType)
        .WithMany(qt => qt.Questions)
        .HasForeignKey(q => q.QuestionTypeId);

    builder
        .HasMany(q => q.Answers)
        .WithOne(a => a.Question)
        .HasForeignKey(a => a.QuestionId);
  }
}
