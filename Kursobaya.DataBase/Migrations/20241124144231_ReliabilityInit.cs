using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Kursobaya.Storage.Migrations
{
    /// <inheritdoc />
    public partial class ReliabilityInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reliability",
                table: "Units");

            migrationBuilder.CreateTable(
                name: "Reliabilitys",
                columns: table => new
                {
                    ResultID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnitCode = table.Column<Guid>(type: "uuid", nullable: false),
                    DetailCode = table.Column<Guid>(type: "uuid", nullable: false),
                    dost = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reliabilitys", x => x.ResultID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reliabilitys");

            migrationBuilder.AddColumn<string>(
                name: "Reliability",
                table: "Units",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
