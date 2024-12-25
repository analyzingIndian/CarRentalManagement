using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9c4a060c-d26d-42ed-9b1f-4e5fbe3b1b8a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOxpZqQKz524tmefsjBqeJik92tPYPGd0GLmCmNlPdnFyXN/P+UUGSB5VUIGbhK1TA==", null, false, "6e488e85-0592-41d3-9a85-5462b0980ac3", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(1850), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(1865), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2131), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2297), new DateTime(2024, 11, 25, 17, 59, 18, 949, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6847), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6957), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6959), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 11, 19, 12, 15, 43, 25, DateTimeKind.Local).AddTicks(6962) });
        }
    }
}
