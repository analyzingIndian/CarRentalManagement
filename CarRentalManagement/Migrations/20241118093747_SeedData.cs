using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(218), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(234), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(236), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(236), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(427), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(428), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(430), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(523), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(525), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(525), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 11, 18, 17, 37, 46, 636, DateTimeKind.Local).AddTicks(527), "Prius", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "model",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
