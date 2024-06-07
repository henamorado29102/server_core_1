using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class addLeagueMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Coaches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Coaches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "LeagueId", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(2024, 6, 4, 22, 16, 27, 881, DateTimeKind.Unspecified).AddTicks(6660), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "LeagueId", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(2024, 6, 4, 22, 16, 27, 881, DateTimeKind.Unspecified).AddTicks(6670), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "LeagueId", "ModifiedBy", "ModifiedDate" },
                values: new object[] { null, new DateTime(2024, 6, 4, 22, 16, 27, 881, DateTimeKind.Unspecified).AddTicks(6670), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_AwayTeamId",
                table: "Matches",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamId",
                table: "Matches",
                column: "HomeTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Teams_TeamId",
                table: "Coaches",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Teams_TeamId",
                table: "Coaches");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_TeamId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Coaches");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 18, 53, 19, 608, DateTimeKind.Unspecified).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 18, 53, 19, 608, DateTimeKind.Unspecified).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 4, 18, 53, 19, 608, DateTimeKind.Unspecified).AddTicks(5210));
        }
    }
}
