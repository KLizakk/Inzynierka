using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inzynierka.Data.Migrations
{
    /// <inheritdoc />
    public partial class Drivers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionNeeded = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "GD9988LK",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 5, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 2, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6651), new DateTime(2023, 12, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "KR6789XYZ",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6627), new DateTime(2024, 8, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 7, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PL1234ABC",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 9, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 6, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 3, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PO1122RT",
                column: "LastInsurance",
                value: new DateTime(2024, 9, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "WA4455GH",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 6, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 4, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6636), new DateTime(2024, 1, 28, 17, 37, 0, 844, DateTimeKind.Local).AddTicks(6634) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "GD9988LK",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 5, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 2, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 12, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "KR6789XYZ",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 8, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 7, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PL1234ABC",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 9, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 6, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 3, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PO1122RT",
                column: "LastInsurance",
                value: new DateTime(2024, 9, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "WA4455GH",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 6, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 4, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 1, 28, 17, 26, 51, 437, DateTimeKind.Local).AddTicks(2862) });
        }
    }
}
