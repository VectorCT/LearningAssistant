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
        .HasMaxLength(4000);

    builder
        .Property(mca => mca.Options)
        .HasMaxLength(4000);

    builder
        .Property(mca => mca.Explanation)
        .HasMaxLength(2000);
  }
}
