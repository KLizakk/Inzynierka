using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inzynierka.Migrations
{
    /// <inheritdoc />
    public partial class X : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1564c939-14da-4105-95ce-14fe68693989");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32b07cf3-3c5f-4175-8ca5-6d27b2b5f525");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4d3c2e8-bf97-4f10-9a39-27ad732896e8");

            migrationBuilder.AddColumn<double>(
                name: "DistanceTraveled",
                table: "Rentals",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PermissionNeeded",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f223d42-f2ea-45a5-9841-4a06eead6c61", null, "Koordynator", "KOORDYNATOR" },
                    { "64377dfc-6689-44a0-918d-edc5e69bb51a", null, "Admin", "ADMIN" },
                    { "db3ec7df-c349-4037-8446-3397b90e7228", null, "Kierowca", "KIEROWCA" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "GD9988LK",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 7, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(3012), new DateTime(2024, 4, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 2, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "KR6789XYZ",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 10, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2987), new DateTime(2024, 9, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PL1234ABC",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2976), new DateTime(2024, 8, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2978), new DateTime(2024, 5, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PO1122RT",
                column: "LastInsurance",
                value: new DateTime(2024, 11, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "WA4455GH",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 8, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2996), new DateTime(2024, 6, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 3, 13, 14, 24, 59, 294, DateTimeKind.Local).AddTicks(2995) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f223d42-f2ea-45a5-9841-4a06eead6c61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64377dfc-6689-44a0-918d-edc5e69bb51a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db3ec7df-c349-4037-8446-3397b90e7228");

            migrationBuilder.DropColumn(
                name: "DistanceTraveled",
                table: "Rentals");

            migrationBuilder.AlterColumn<int>(
                name: "PermissionNeeded",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1564c939-14da-4105-95ce-14fe68693989", null, "Koordynator", "KOORDYNATOR" },
                    { "32b07cf3-3c5f-4175-8ca5-6d27b2b5f525", null, "Kierowca", "KIEROWCA" },
                    { "b4d3c2e8-bf97-4f10-9a39-27ad732896e8", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "GD9988LK",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 3, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 1, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "KR6789XYZ",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 11, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 9, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 8, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PL1234ABC",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 10, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 7, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 4, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PO1122RT",
                column: "LastInsurance",
                value: new DateTime(2024, 10, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "WA4455GH",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 5, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 2, 19, 15, 48, 7, 867, DateTimeKind.Local).AddTicks(6285) });
        }
    }
}
