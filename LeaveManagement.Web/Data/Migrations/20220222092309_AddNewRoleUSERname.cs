using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddNewRoleUSERname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a",
                column: "ConcurrencyStamp",
                value: "61f7549a-6112-420c-80c1-c9afbb8855c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a",
                column: "ConcurrencyStamp",
                value: "4ecf8464-d834-44c2-9317-9f790fb2a1eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ab574906-a48f-43b8-8a76-36bb2ca20979", true, "SHIVANGI2000@GMAIL.COM", "AQAAAAEAACcQAAAAEFHQy6LtKxRrXtWNKx5elaxRxGKi8A0q/oL17RO9lBYjMV1iPzhrk9CbnejpDbXKnA==", "876f1fdc-1c29-4802-8c8d-fe55d76da21c", "shivangi2000@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4113443c-dfe6-40c4-8475-4375f90adc8e", true, "KSDARJI2001@GMAIL.COM", "AQAAAAEAACcQAAAAEP7w/0diEyzHIu7xIOgwqwyEeJmEG9SxTmFm2K0S85/ybPeQlNQUAUjM5piMtZ9lAA==", "d4d82e30-c474-42a3-bd2b-336b19416320", "ksdarji2001@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a",
                column: "ConcurrencyStamp",
                value: "664a40d3-14ff-4a23-b100-215d22a14258");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a",
                column: "ConcurrencyStamp",
                value: "250ed04a-2aa3-45f4-b2bd-3a92cae2545d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "af022e1a-9578-47fb-b51a-9ee76536c190", false, null, "AQAAAAEAACcQAAAAEC4rr6QvreZl3BoiF9fKxkO1VGO0DryfPCGdchs3WGiGTnK2SzmI4uQb693/rryYvw==", "13d28dde-a405-465d-8ac1-39c526179977", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "decf1c84-888c-4a3c-82f2-3cee3af5b1a6", false, null, "AQAAAAEAACcQAAAAEMjuf62s05QPMLHEetjW0IaAiHuNzIGjIlYma3DhOgJeeWPpc+eokD/4mEWa/UxiFA==", "4af670af-e3fb-4d84-aa6f-f2b1510e3316", null });
        }
    }
}
