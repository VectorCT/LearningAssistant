using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations;

public class AdditionalTextBookConfiguration : IEntityTypeConfiguration<AdditionalTextBook>
{
  public void Configure(EntityTypeBuilder<AdditionalTextBook> builder)
  {
    builder.HasKey(at => at.Id);

    builder
        .Property(at => at.BookTitle)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .Property(at => at.BookFilePath)
        .HasMaxLength(500)
        .IsRequired();

    builder
        .HasOne(at => at.Subject)
        .WithMany(s => s.AdditionalTextBooks)
        .HasForeignKey(at => at.SubjectId);
  }
}
