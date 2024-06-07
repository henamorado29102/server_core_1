using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 4, 18, 53, 19, 608, DateTimeKind.Unspecified).AddTicks(5200), "Team A" },
                    { 2, new DateTime(2024, 6, 4, 18, 53, 19, 608, DateTimeKind.Unspecified).AddTicks(5210), "Team B" },
                    { 3, new DateTime(2024, 6, 4, 18, 53, 19, 608, DateTimeKind.Unspecified).AddTicks(5210), "Team C" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
