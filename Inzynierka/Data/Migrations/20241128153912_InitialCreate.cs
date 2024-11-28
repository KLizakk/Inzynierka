using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inzynierka.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    RegistrationNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionNeeded = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionYear = table.Column<int>(type: "int", nullable: true),
                    EngineCapacity = table.Column<int>(type: "int", nullable: true),
                    CarType = table.Column<int>(type: "int", nullable: true),
                    ExhaustGasEmissionCategory = table.Column<int>(type: "int", nullable: true),
                    FuelType = table.Column<int>(type: "int", nullable: true),
                    GearboxType = table.Column<int>(type: "int", nullable: true),
                    DriveType = table.Column<int>(type: "int", nullable: true),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: true),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: true),
                    NumberOfGears = table.Column<int>(type: "int", nullable: true),
                    LastTechnicalReview = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastInsurance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastOilChange = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FuelConsumption = table.Column<double>(type: "float", nullable: true),
                    FuelTankCapacity = table.Column<double>(type: "float", nullable: true),
                    MaxDistance = table.Column<double>(type: "float", nullable: true),
                    MaxLoad = table.Column<double>(type: "float", nullable: true),
                    TreadCondition = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.RegistrationNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
