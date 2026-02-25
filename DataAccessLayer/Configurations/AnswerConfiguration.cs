using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
  public void Configure(EntityTypeBuilder<Answer> builder)
  {
    builder
        .Property(a => a.Description)
        .HasMaxLength(500)
        .IsRequired();

    builder
        .Property(a => a.CreatedAt)
        .HasDefaultValueSql("GETDATE()");

    builder
        .HasOne(a => a.Question)
        .WithMany(q => q.Answers)
        .HasForeignKey(a => a.QuestionId);

    // Discriminator configuration for polymorphism
    builder
        .HasDiscriminator<string>("AnswerType")
        .HasValue<MultipleChoiceAnswer>("MultipleChoice")
        .HasValue<TrueFalseAnswer>("TrueFalse");
  }
}
