using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id= "093afa8c-67e3-4103-a532-8add12940f9a",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",

                },
                 new IdentityRole
                 {
                     Id = "093adf8c-67e3-1403-a986-8add36940f9a",
                     Name = "User",
                     NormalizedName = "USER",

                 }
             );
        }
    }
}