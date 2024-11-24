using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursobaya.Storage.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    DetailCode = table.Column<Guid>(type: "uuid", nullable: false),
                    DetailType = table.Column<string>(type: "text", nullable: false),
                    UnitCode = table.Column<Guid>(type: "uuid", nullable: false),
                    dm1 = table.Column<double>(type: "double precision", nullable: false),
                    U = table.Column<double>(type: "double precision", nullable: false),
                    Zh = table.Column<double>(type: "double precision", nullable: false),
                    Zm = table.Column<double>(type: "double precision", nullable: false),
                    Khl = table.Column<double>(type: "double precision", nullable: false),
                    sigma = table.Column<double>(type: "double precision", nullable: false),
                    delta_h = table.Column<double>(type: "double precision", nullable: false),
                    Vm = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.DetailCode);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitCode = table.Column<Guid>(type: "uuid", nullable: false),
                    Reliability = table.Column<string>(type: "text", nullable: false),
                    Kh = table.Column<double>(type: "double precision", nullable: false),
                    Kha = table.Column<double>(type: "double precision", nullable: false),
                    Khb = table.Column<double>(type: "double precision", nullable: false),
                    Khv = table.Column<double>(type: "double precision", nullable: false),
                    Ft = table.Column<double>(type: "double precision", nullable: false),
                    Ea = table.Column<double>(type: "double precision", nullable: false),
                    b = table.Column<double>(type: "double precision", nullable: false),
                    g0 = table.Column<double>(type: "double precision", nullable: false),
                    Re = table.Column<double>(type: "double precision", nullable: false),
                    SigmaH = table.Column<double>(type: "double precision", nullable: false),
                    SigmaHP = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitCode);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_UnitCode",
                table: "Details",
                column: "UnitCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
