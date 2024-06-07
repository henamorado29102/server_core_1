using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class addLeagueMatch1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LeagueId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 6, 4, 22, 16, 27, 881, DateTimeKind.Unspecified).AddTicks(6660), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Team A" },
                    { 2, null, new DateTime(2024, 6, 4, 22, 16, 27, 881, DateTimeKind.Unspecified).AddTicks(6670), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Team B" },
                    { 3, null, new DateTime(2024, 6, 4, 22, 16, 27, 881, DateTimeKind.Unspecified).AddTicks(6670), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Team C" }
                });
        }
    }
}
