using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093adf8c-67e3-1403-a986-8add36940f9a",
                column: "ConcurrencyStamp",
                value: "2e18043e-5e2a-4330-bf0f-c2313ec2412c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "093afa8c-67e3-4103-a532-8add12940f9a",
                column: "ConcurrencyStamp",
                value: "fbb180ee-2955-4759-8939-aac54ae63b8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57508d59-d2c7-4514-9e08-4ad57851ae70", "AQAAAAEAACcQAAAAEELfapoMLLm4YypiFzAjUZXqV9wSdLb4xyGcGHRCZwNU/CN/m43G2k/gQgUC+Wvp2g==", "863f42d7-fd02-4fb0-92ab-24134a65eac3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5103f930-518a-474b-8624-8504edb56f22", "AQAAAAEAACcQAAAAEGO/rDbOXHGrPq2KFswObrhNz7HP85FVRw8T7qT5kYnP2gUsikPJHlL6oFiM+XpUzA==", "f747b9dc-70c5-4ac6-8355-51ebfcc57b35" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
