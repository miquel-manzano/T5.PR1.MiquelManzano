using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergySolutions.Migrations
{
    /// <inheritdoc />
    public partial class AddSimulationsTableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Simulations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SunHours = table.Column<int>(type: "int", nullable: false),
                    WindSpeed = table.Column<double>(type: "float", nullable: false),
                    WaterFlow = table.Column<double>(type: "float", nullable: false),
                    Ratio = table.Column<double>(type: "float", nullable: false),
                    GeneratedEnergy = table.Column<double>(type: "float", nullable: false),
                    KWhCost = table.Column<double>(type: "float", nullable: false),
                    KWhPrice = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simulations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Simulations");
        }
    }
}
