using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "094afa8c-69e3-4103-a542-8aee12940f9a",
                    Email = "shivangi2000@gmail.com",
                    NormalizedEmail = "SHIVANGI2000@GMAIL.COM",
                    NormalizedUserName = "SHIVANGI2000@GMAIL.COM",
                    UserName = "shivangi2000@gmail.com",
                    FirstName = "Shivangi",
                    LastName = "Lad",
                    PasswordHash = hasher.HashPassword(null,"Shivangi@123"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "9f074bba-372c-474e-81a2-92e877a73075",
                    Email = "ksdarji2001@gmail.com",
                    NormalizedEmail = "KSDARJI2001@GMAIL.COM",
                    NormalizedUserName = "KSDARJI2001@GMAIL.COM",
                    UserName= "ksdarji2001@gmail.com",
                    FirstName = "KRINA",
                    LastName = "DARJI",
                    PasswordHash = hasher.HashPassword(null, "Krina@123"),
                    EmailConfirmed =true
                }
        );
                
        }
    }
}
