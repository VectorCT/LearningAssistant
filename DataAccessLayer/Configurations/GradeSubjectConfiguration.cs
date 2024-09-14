using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class GradeSubjectConfiguration : IEntityTypeConfiguration<GradeSubject>
{
  public void Configure(EntityTypeBuilder<GradeSubject> builder)
  {
    builder.HasKey(gs => new { gs.GradeId, gs.SubjectId });

    builder
        .HasOne(gs => gs.Grade)
        .WithMany(g => g.GradeSubjects)
        .HasForeignKey(gs => gs.GradeId);

    builder
        .HasOne(gs => gs.Subject)
        .WithMany(s => s.GradeSubjects)
        .HasForeignKey(gs => gs.SubjectId);
  }
}
