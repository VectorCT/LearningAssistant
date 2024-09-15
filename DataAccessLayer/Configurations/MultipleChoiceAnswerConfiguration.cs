using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class MultipleChoiceAnswerConfiguration : IEntityTypeConfiguration<MultipleChoiceAnswer>
{
  public void Configure(EntityTypeBuilder<MultipleChoiceAnswer> builder)
  {
    builder
        .Property(mca => mca.CorrectOption)
        .IsRequired();

    builder
        .Property(mca => mca.Explanation)
        .HasMaxLength(1000);  // Optional explanation length
  }
}
