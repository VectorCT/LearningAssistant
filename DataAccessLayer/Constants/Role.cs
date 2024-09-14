using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Constants;

public class Role
{
  public const string RoleAdministrator = "Administrator";
  public const string RoleGuestUser = "Guest User";
  public const string RoleStudentUser = "Student User";
  public const string RolePremiumUser = "Premium User";

  public string[] AllowedToCreate { get; set; } = null!;
  public IdentityRole IdentityRole { get; set; } = null!;

  public static Dictionary<string, Role> Lookup { get; }
      = new Dictionary<string, Role>()
      {
            {
                RoleAdministrator,
                new Role {
                    AllowedToCreate = [
                        RoleAdministrator,
                    ],
                    IdentityRole = new IdentityRole
                    {
                        Id = "ddb92a36-c523-4ad0-af07-be8d64670dbc",
                        Name = RoleAdministrator
                    }
                }
            },
            {
                RoleGuestUser,
                new Role {
                    AllowedToCreate = [],
                    IdentityRole = new IdentityRole
                    {
                        Id = "b714b815-d0b2-4101-bfac-0364de42d14d",
                        Name = RoleGuestUser
                    }
                }
            },
            {
                RoleStudentUser,
                new Role
                {
                    AllowedToCreate = [RoleStudentUser],
                    IdentityRole = new IdentityRole
                    {
                        Id = "3e71747b-dbc9-4e4f-a34d-d4ceed2c809b",
                        Name = RoleStudentUser
                    }
                }
            }
  };
}
