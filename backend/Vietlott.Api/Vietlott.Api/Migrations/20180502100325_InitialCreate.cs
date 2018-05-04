using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vietlott.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrawGames",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrawTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DrawGameId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrawTypes_DrawGames_DrawGameId",
                        column: x => x.DrawGameId,
                        principalTable: "DrawGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrawResults",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DrawDate = table.Column<DateTime>(nullable: false),
                    DrawNo = table.Column<int>(nullable: false),
                    DrawTypeId = table.Column<string>(nullable: true),
                    PrizeAmount = table.Column<decimal>(nullable: false),
                    TotalWinningTickets = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrawResults_DrawTypes_DrawTypeId",
                        column: x => x.DrawTypeId,
                        principalTable: "DrawTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WinningNumber",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DrawResultId = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinningNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WinningNumber_DrawResults_DrawResultId",
                        column: x => x.DrawResultId,
                        principalTable: "DrawResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrawResults_DrawTypeId",
                table: "DrawResults",
                column: "DrawTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawTypes_DrawGameId",
                table: "DrawTypes",
                column: "DrawGameId");

            migrationBuilder.CreateIndex(
                name: "IX_WinningNumber_DrawResultId",
                table: "WinningNumber",
                column: "DrawResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WinningNumber");

            migrationBuilder.DropTable(
                name: "DrawResults");

            migrationBuilder.DropTable(
                name: "DrawTypes");

            migrationBuilder.DropTable(
                name: "DrawGames");
        }
    }
}
