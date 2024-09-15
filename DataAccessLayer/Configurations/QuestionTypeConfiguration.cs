using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class QuestionTypeConfiguration : IEntityTypeConfiguration<QuestionType>
{
  public void Configure(EntityTypeBuilder<QuestionType> builder)
  {
    builder
        .Property(qt => qt.TypeName)
        .HasMaxLength(100)
        .IsRequired();

    builder
        .HasMany(qt => qt.Questions)
        .WithOne(q => q.QuestionType)
        .HasForeignKey(q => q.QuestionTypeId);
  }
}
