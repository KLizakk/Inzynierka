using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inzynierka.Data.Migrations
{
    /// <inheritdoc />
    public partial class CarsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegistrationNumber", "Brand", "CarType", "Description", "DriveType", "EngineCapacity", "ExhaustGasEmissionCategory", "FuelConsumption", "FuelTankCapacity", "FuelType", "GearboxType", "LastInsurance", "LastOilChange", "LastTechnicalReview", "MaxDistance", "MaxLoad", "Model", "NumberOfDoors", "NumberOfGears", "NumberOfSeats", "PermissionNeeded", "ProductionYear", "TreadCondition", "VIN" },
                values: new object[,]
                {
                    { "ABC12345", "Tesla", 0, "Electric sedan", 2, 0, 6, 0.0, null, 4, 1, null, null, null, 600.0, 500.0, "Model S", 4, 1, 5, 1, 2021, 80.0, "5YJSA1E26MF123456" },
                    { "GD9988LK", "Dacia", 2, "Affordable off-road SUV", 0, 1500, 4, 5.2999999999999998, 50.0, 1, 0, new DateTime(2024, 5, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 2, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 12, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2875), 950.0, 470.0, "Duster", 5, 5, 5, 1, 2017, 60.0, "UU1KSDMJ455123456" },
                    { "KR6789XYZ", "Mercedes-Benz", 0, "Luxury sedan", 1, 2000, 5, 4.7999999999999998, 60.0, 5, 1, new DateTime(2024, 10, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 8, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 7, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2854), 1100.0, 480.0, "C-Class", 4, 9, 5, 1, 2021, 90.0, "WDD2050741F123456" },
                    { "PL1234ABC", "Volkswagen", 1, "Popular compact car", 0, 1600, 5, 5.5, 50.0, 1, 0, new DateTime(2024, 9, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 6, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 3, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2793), 900.0, 450.0, "Golf", 5, 6, 5, 1, 2020, 80.0, "WVWZZZ1KZ6P123456" },
                    { "PO1122RT", "Tesla", 0, "Electric car", 2, 0, 6, 0.0, null, 4, 1, new DateTime(2024, 9, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2869), null, null, 560.0, 430.0, "Model 3", 4, 1, 5, 1, 2022, 85.0, "5YJ3E1EA7KF123456" },
                    { "WA4455GH", "Mazda", 2, "Mid-size SUV", 2, 2200, 5, 7.2000000000000002, 58.0, 1, 1, new DateTime(2024, 6, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 4, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 1, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2862), 800.0, 500.0, "CX-5", 5, 6, 5, 1, 2018, 75.0, "JMZKF1W1A01234567" },
                    { "XYZ98765", "Honda", 1, "Compact car", 0, 1800, 5, 6.5, 45.0, 0, 0, null, null, null, 700.0, 400.0, "Civic", 5, 6, 5, 1, 2019, 70.0, "1HGEM21901L123456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "ABC12345");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "GD9988LK");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "KR6789XYZ");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PL1234ABC");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PO1122RT");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "WA4455GH");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "XYZ98765");
        }
    }
}
