using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(580), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(580), "Premier League" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LeagueId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(650), "Team 1" },
                    { 2, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(650), "Team 2" },
                    { 3, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 3" },
                    { 4, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 4" },
                    { 5, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 5" },
                    { 6, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 6" },
                    { 7, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 7" },
                    { 8, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 8" },
                    { 9, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 9" },
                    { 10, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(660), "Team 10" }
                });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 1", 1 },
                    { 2, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 2", 2 },
                    { 3, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 3", 3 },
                    { 4, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 4", 4 },
                    { 5, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 5", 5 },
                    { 6, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 6", 6 },
                    { 7, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 7", 7 },
                    { 8, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(690), "Coach 8", 8 },
                    { 9, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(700), "Coach 9", 9 },
                    { 10, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(700), "Coach 10", 10 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "AwayTeamId", "CreatedBy", "CreatedDate", "Date", "HomeTeamId", "ModifiedBy", "ModifiedDate", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(720), new DateTime(2024, 6, 5, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(720), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(720), 50m },
                    { 2, 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 6, 6, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 50m },
                    { 3, 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 6, 7, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 50m },
                    { 4, 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 6, 8, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 50m },
                    { 5, 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 6, 9, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 50m },
                    { 6, 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 6, 10, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 50m },
                    { 7, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), new DateTime(2024, 6, 11, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(730), 50m },
                    { 8, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 12, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 9, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 13, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 1, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 10, 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 14, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 11, 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 15, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 12, 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 16, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 13, 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 17, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 14, 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 18, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 15, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 19, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 16, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 20, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 17, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 21, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 2, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 18, 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 22, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 50m },
                    { 19, 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 23, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(740), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 20, 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 24, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 21, 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 25, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 22, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 26, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 23, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 27, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 24, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 28, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 3, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 25, 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 29, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 26, 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 6, 30, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 27, 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 7, 1, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 28, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 7, 2, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 29, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 7, 3, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 30, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), new DateTime(2024, 7, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 4, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(750), 50m },
                    { 31, 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 5, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 32, 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 6, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 33, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 7, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 34, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 8, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 35, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 9, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 5, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 36, 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 10, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 37, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 11, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 38, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 12, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 39, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 13, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 6, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 40, 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 14, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 41, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 15, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 50m },
                    { 42, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), new DateTime(2024, 7, 16, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(760), 7, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 50m },
                    { 43, 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 7, 17, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 50m },
                    { 44, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 7, 18, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 8, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 50m },
                    { 45, 10, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 7, 19, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 9, "System", new DateTime(2024, 6, 4, 22, 37, 31, 656, DateTimeKind.Utc).AddTicks(770), 50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 45);

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

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
