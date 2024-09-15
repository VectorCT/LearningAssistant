using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
  public void Configure(EntityTypeBuilder<ApplicationUser> builder)
  {
    // IdentityUser already has the primary key, no need to set it again

    builder
        .Property(u => u.IsAccountDisabled)
        .IsRequired();

    builder
        .Property(u => u.Name)
        .HasMaxLength(255)
        .IsRequired();

    builder
        .Property(u => u.Surname)
        .HasMaxLength(255)
        .IsRequired();

    // Relationships
    builder
        .HasMany(u => u.Comments)
        .WithOne(c => c.User)
        .HasForeignKey(c => c.UserId);

    builder
        .HasMany(u => u.UserReactions)
        .WithOne(r => r.User)
        .HasForeignKey(r => r.UserId);

    // Optionally seed default admin user (replace the values with real ones)
    var hasher = new PasswordHasher<ApplicationUser>();

    builder.HasData(
        new ApplicationUser
        {
          Id = "default-admin-id", // This would be a GUID in production
          UserName = "admin",
          Email = "calvintshabalala9@gmail.com",
          NormalizedUserName = "ADMIN",
          NormalizedEmail = "CALVINTSHABALALA9@GMAIL.COM",
          PasswordHash = hasher.HashPassword(null, "Admin@123"),
          Name = "Admin",
          Surname = "User",
          EmailConfirmed = true
        }
    );
  }
}
