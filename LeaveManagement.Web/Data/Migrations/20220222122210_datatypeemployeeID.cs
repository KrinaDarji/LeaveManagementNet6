using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class datatypeemployeeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a",
                column: "ConcurrencyStamp",
                value: "c0b7787e-6951-442d-9792-8edeb363538d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a",
                column: "ConcurrencyStamp",
                value: "8f858c1c-a4f5-4c9b-b700-1afa623d7c47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c38eba19-65b9-43be-8c9e-f45191594796", "AQAAAAEAACcQAAAAEKH+wnj8p8jw3Gh9p4YN2TB7LRGiM3jxUawX1AlYS5pOixbveSsLoHJaHgsfh8ZIOw==", "527dc8f5-f9e2-46ff-9c1b-7242996d69b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e7a7cce-884b-47a5-aa1b-a064bc41a597", "AQAAAAEAACcQAAAAECnT+in3iVj/7vW2dmpmJQPUqdk7cm1Lt8Hp7hcGJ15SfC+syyQV+wor+vuVmFCDPQ==", "a421b3f8-79ae-44fb-a14c-ed7fb92bb1ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
