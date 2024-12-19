using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inzynierka.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToDriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4635cf1c-a464-479a-a5a1-0c1fcec93d21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c232c45b-7e53-4c45-853e-258bb35daf37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81dff0f-9efd-44cb-ac7f-b8743988739a");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Drivers",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 1,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverId",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_UserId",
                table: "Drivers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_AspNetUsers_UserId",
                table: "Drivers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_AspNetUsers_UserId",
                table: "Drivers");

            migrationBuilder.DropIndex(
                name: "IX_Drivers_UserId",
                table: "Drivers");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Drivers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4635cf1c-a464-479a-a5a1-0c1fcec93d21", null, "Koordynator", "KOORDYNATOR" },
                    { "c232c45b-7e53-4c45-853e-258bb35daf37", null, "Kierowca", "KIEROWCA" },
                    { "f81dff0f-9efd-44cb-ac7f-b8743988739a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "GD9988LK",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 3, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2976), new DateTime(2024, 1, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "KR6789XYZ",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 9, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2945), new DateTime(2024, 8, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PL1234ABC",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 7, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2934), new DateTime(2024, 4, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "PO1122RT",
                column: "LastInsurance",
                value: new DateTime(2024, 10, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "RegistrationNumber",
                keyValue: "WA4455GH",
                columns: new[] { "LastInsurance", "LastOilChange", "LastTechnicalReview" },
                values: new object[] { new DateTime(2024, 7, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 5, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 2, 18, 17, 8, 44, 128, DateTimeKind.Local).AddTicks(2956) });
        }
    }
}
