using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddNewRoleUSERandADMIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "093afa8c-67e3-4103-a532-8add12940f9a", "250ed04a-2aa3-45f4-b2bd-3a92cae2545d", "Administrator", "ADMINISTRATOR" },
                    { "093adf8c-67e3-1403-a986-8add36940f9a", "664a40d3-14ff-4a23-b100-215d22a14258", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "094afa8c-69e3-4103-a542-8aee12940f9a", 0, "af022e1a-9578-47fb-b51a-9ee76536c190", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "shivangi2000@gmail.com", false, "Shivangi", "Lad", false, null, "SHIVANGI2000@GMAIL.COM", null, "AQAAAAEAACcQAAAAEC4rr6QvreZl3BoiF9fKxkO1VGO0DryfPCGdchs3WGiGTnK2SzmI4uQb693/rryYvw==", null, false, "13d28dde-a405-465d-8ac1-39c526179977", null, false, null },
                    { "9f074bba-372c-474e-81a2-92e877a73075", 0, "decf1c84-888c-4a3c-82f2-3cee3af5b1a6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ksdarji2001@gmail.com", false, "KRINA", "DARJI", false, null, "KSDARJI2001@GMAIL.COM", null, "AQAAAAEAACcQAAAAEMjuf62s05QPMLHEetjW0IaAiHuNzIGjIlYma3DhOgJeeWPpc+eokD/4mEWa/UxiFA==", null, false, "4af670af-e3fb-4d84-aa6f-f2b1510e3316", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "093afa8c-67e3-4103-a532-8add12940f9a", "094afa8c-69e3-4103-a542-8aee12940f9a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "093adf8c-67e3-1403-a986-8add36940f9a", "9f074bba-372c-474e-81a2-92e877a73075" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "093afa8c-67e3-4103-a532-8add12940f9a", "094afa8c-69e3-4103-a542-8aee12940f9a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "093adf8c-67e3-1403-a986-8add36940f9a", "9f074bba-372c-474e-81a2-92e877a73075" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075");
        }
    }
}
