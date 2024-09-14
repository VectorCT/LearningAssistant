using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
  public class GradeConfiguration : IEntityTypeConfiguration<Grade>
  {
    public void Configure(EntityTypeBuilder<Grade> builder)
    {
      builder
                .Property(g => g.Name)
                .HasMaxLength(50)
                .IsRequired();

      builder.HasData(
          new Grade { Id = Guid.Parse("b714b815-d0b2-4101-bfac-0364de42d14d"), Name = "Grade 9" },
          new Grade { Id = Guid.Parse("3e71747b-dbc9-4e4f-a34d-d4ceed2c809b"), Name = "Grade 10" },
          new Grade { Id = Guid.Parse("09a00c75-3063-4f32-8033-ad78188d2ec6"), Name = "Grade 11" },
          new Grade { Id = Guid.Parse("a4641e89-a22d-4c52-beea-56e38f38227a"), Name = "Grade 12" }
      );
    }
  }
}
