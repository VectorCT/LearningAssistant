using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class ForumConfiguration : IEntityTypeConfiguration<Forum>
{
  public void Configure(EntityTypeBuilder<Forum> builder)
  {
    builder
        .Property(f => f.Topic)
        .HasMaxLength(200)
        .IsRequired();

    builder
        .Property(f => f.DiscussionQuestion)
        .HasMaxLength(500)
        .IsRequired();

    builder
        .HasMany(f => f.Comments)
        .WithOne(c => c.Forum)
        .HasForeignKey(c => c.ForumId);

    builder
        .Property(c => c.CreatedAt)
        .HasDefaultValueSql("GETDATE()");
    builder
        .HasOne(pp => pp.Subject)
        .WithMany(s => s.Forums)
        .HasForeignKey(pp => pp.SubjectId);

    builder.HasData(
         new Forum { Id = Guid.NewGuid(), SubjectId = Guid.Parse("3FE2283B-6751-4633-8903-2043997BBF20"), Topic = "Difficult problems in Algebra", DiscussionQuestion = "What are common algebra problems students face?" },
         new Forum { Id = Guid.NewGuid(), SubjectId = Guid.Parse("B2DF6DB3-2B38-4C3A-9517-5E3E2B98B741"), Topic = "Physics Chapter 1", DiscussionQuestion = "How do we understand Newton’s Laws?" },
         new Forum { Id = Guid.NewGuid(), SubjectId = Guid.Parse("B2DF6DB3-2B38-4C3A-9517-5E3E2B98B741"), Topic = "Best study guides?", DiscussionQuestion = "What are the best study guides for exam preparation?" },
         new Forum { Id = Guid.NewGuid(), SubjectId = Guid.Parse("B2DF6DB3-2B38-4C3A-9517-5E3E2B98B741"), Topic = "Exam preparation tips", DiscussionQuestion = "How should I approach exam preparation effectively?" },
         new Forum { Id = Guid.NewGuid(), SubjectId = Guid.Parse("B2DF6DB3-2B38-4C3A-9517-5E3E2B98B741"), Topic = "Difficult problems in Algebra", DiscussionQuestion = "What are common algebra problems students face?" }
    );
  }
}
