using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "093afa8c-67e3-4103-a532-8add12940f9a",
                    UserId= "094afa8c-69e3-4103-a542-8aee12940f9a"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "093adf8c-67e3-1403-a986-8add36940f9a",
                     UserId = "9f074bba-372c-474e-81a2-92e877a73075"
                 }
                );
        }
    }
}