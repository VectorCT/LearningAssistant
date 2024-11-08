using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations
{
  public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
  {
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
      builder
          .Property(s => s.Name)
          .HasMaxLength(100)
          .IsRequired();

      builder
          .Property(s => s.PrescribedTextBook)
          .HasMaxLength(200);

      builder
        .Property(s => s.SubjectDescription)
        .HasMaxLength(255)
        .IsRequired();

      builder
        .Property(s => s.PrescribedTextBookFileUrl)
        .HasMaxLength(500)
        .IsRequired();

      builder
        .Property(s => s.SubjectImageUrl)
        .HasMaxLength(500)
        .IsRequired();

      // Relationships
      builder
          .HasMany(s => s.AdditionalTextBooks)
          .WithOne(at => at.Subject)
          .HasForeignKey(at => at.SubjectId);

      builder
          .HasMany(s => s.Chapters)
          .WithOne(c => c.Subject)
          .HasForeignKey(c => c.SubjectId);

      builder
          .HasMany(s => s.VideoTutorials)
          .WithOne(v => v.Subject)
          .HasForeignKey(v => v.SubjectId);

      builder
          .HasMany(s => s.PastPapers)
          .WithOne(p => p.Subject)
          .HasForeignKey(p => p.SubjectId);
      builder
          .HasMany(s => s.Forums)
          .WithOne(p => p.Subject)
          .HasForeignKey(p => p.SubjectId);

     builder.HasData(
         new Subject { Id = Guid.Parse("5a5da2f4-f649-4994-95b1-228b82e9d98c"), Name = "Mathematics", PrescribedTextBook = "MathBook.pdf", SubjectDescription = "Math Description" },
         new Subject { Id = Guid.Parse("4b1e2df5-c5ad-488e-94d6-b249d1016c40"), Name = "Science", PrescribedTextBook = "Physics Textbook" , SubjectDescription = "Science Description" },
         new Subject { Id = Guid.Parse("c62a461a-0ab8-4bd7-83c4-a1bbb56a4772"), Name = "Geography", PrescribedTextBook = "Geography Textbook" , SubjectDescription = "Geography Description" },
         new Subject { Id = Guid.Parse("8bae0fe9-7853-4d3d-949c-b5537303f330"), Name = "Life Science", PrescribedTextBook = "Biology Textbook", SubjectDescription = "Life Science Description" },
         new Subject { Id = Guid.Parse("948e6d61-8d75-46ca-8701-8921979eb1fa"), Name = "Chemistry", PrescribedTextBook = "Chemistry Textbook", SubjectDescription = "Chemistry Description" }
     );
    }
  }
}
