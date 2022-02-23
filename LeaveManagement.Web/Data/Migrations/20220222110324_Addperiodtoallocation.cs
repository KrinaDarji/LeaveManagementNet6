using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class Addperiodtoallocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a",
                column: "ConcurrencyStamp",
                value: "89ab586d-267c-4b98-990f-0f0d3305a678");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a",
                column: "ConcurrencyStamp",
                value: "95e4351e-0635-48b2-b718-01a12468bb1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a73558b-15f7-445c-ab28-92b5315d6159", "AQAAAAEAACcQAAAAEJr1gKzeuXQzUKW//Q8B8YOQsw9PJNccEn+EVzIhJwgHG72Xid05u+DMHh5k6REaZQ==", "33c03b46-a39b-4225-a4c7-cee929b64607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dddf1fe-c6e5-4099-9aac-4c6588866cd3", "AQAAAAEAACcQAAAAEBKFgno6uvNb0HvfBnzOkgb7k6sM1WHHmc0koqkb66fuoUvggEvTpshKg+062EKtzA==", "15a8fd72-8818-487a-8664-7d5a48d9f03c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab574906-a48f-43b8-8a76-36bb2ca20979", "AQAAAAEAACcQAAAAEFHQy6LtKxRrXtWNKx5elaxRxGKi8A0q/oL17RO9lBYjMV1iPzhrk9CbnejpDbXKnA==", "876f1fdc-1c29-4802-8c8d-fe55d76da21c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4113443c-dfe6-40c4-8475-4375f90adc8e", "AQAAAAEAACcQAAAAEP7w/0diEyzHIu7xIOgwqwyEeJmEG9SxTmFm2K0S85/ybPeQlNQUAUjM5piMtZ9lAA==", "d4d82e30-c474-42a3-bd2b-336b19416320" });
        }
    }
}
