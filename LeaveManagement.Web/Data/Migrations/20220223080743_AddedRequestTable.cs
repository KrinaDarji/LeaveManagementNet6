using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a",
                column: "ConcurrencyStamp",
                value: "f445ab2f-f95c-42da-ac29-b0dffda331cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a",
                column: "ConcurrencyStamp",
                value: "cccb53fa-b5d3-43d9-a9cb-354738c22c65");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b315225a-e58a-468a-b33b-d7b40e46903e", "AQAAAAEAACcQAAAAEEHCy/59pN5OULPcxW2VwHj3CptEOiAbhHBNcDxtWyEPCdzaPO7gDApxW/CjbjMybw==", "ce2d9d71-f7d0-448f-9e8b-02ddbbac978c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b4f564-3b55-41c3-ba19-6495aa8398d0", "AQAAAAEAACcQAAAAEChELVIdsPLq/YjLku9TvT+omyEzwnJV91uEYLvfrThgh/eXC1y+WnZNDLBjJqZYgQ==", "eb38bcb9-8d78-4883-99cc-b9f27df2bffb" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
