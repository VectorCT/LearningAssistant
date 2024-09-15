using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Constants;

namespace DataAccessLayer.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
  public void Configure(EntityTypeBuilder<IdentityRole> builder)
  {
    // Configure the IdentityRole entity to include default roles
    builder.HasData(
        new IdentityRole
        {
          Id = "ddb92a36-c523-4ad0-af07-be8d64670dbc",
          Name = Role.RoleAdministrator,
          NormalizedName = "ADMINISTRATOR"
        },
        new IdentityRole
        {
          Id = "b714b815-d0b2-4101-bfac-0364de42d14d",
          Name = Role.RoleGuestUser,
          NormalizedName = "GUEST USER"
        },
        new IdentityRole
        {
          Id = "3e71747b-dbc9-4e4f-a34d-d4ceed2c809b",
          Name = Role.RoleGuestUser,
          NormalizedName = "STUDENT USER"
        },
        new IdentityRole
        {
          Id = "e232ef54-a5b1-4769-8095-bced0fd28df5",
          Name = Role.RolePremiumUser,
          NormalizedName = "PREMIUM USER"
        }
    );
  }
}
