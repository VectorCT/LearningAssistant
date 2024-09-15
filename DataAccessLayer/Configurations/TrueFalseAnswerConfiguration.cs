using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class TrueFalseAnswerConfiguration : IEntityTypeConfiguration<TrueFalseAnswer>
{
  public void Configure(EntityTypeBuilder<TrueFalseAnswer> builder)
  {
    builder
        .Property(tfa => tfa.IsTrue)
        .IsRequired();

    builder
        .Property(tfa => tfa.Explanation)
        .HasMaxLength(500);  // Explanation for true/false
  }
}
