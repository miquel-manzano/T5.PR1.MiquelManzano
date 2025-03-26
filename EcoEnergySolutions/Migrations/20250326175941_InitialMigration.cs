using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoEnergySolutions.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyIndicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NetProduction = table.Column<double>(type: "float", nullable: false),
                    GasolineConsumption = table.Column<double>(type: "float", nullable: true),
                    ElectricDemand = table.Column<double>(type: "float", nullable: true),
                    AvailableProduction = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyIndicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Consumption = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterConsumptions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyIndicators");

            migrationBuilder.DropTable(
                name: "WaterConsumptions");
        }
    }
}
