using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inzynierka.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionNeeded = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_RegistrationNumber",
                        column: x => x.RegistrationNumber,
                        principalTable: "Cars",
                        principalColumn: "RegistrationNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rentals_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegistrationNumber", "Brand", "CarType", "Description", "DriveType", "EngineCapacity", "ExhaustGasEmissionCategory", "FuelConsumption", "FuelTankCapacity", "FuelType", "GearboxType", "LastInsurance", "LastOilChange", "LastTechnicalReview", "MaxDistance", "MaxLoad", "Model", "NumberOfDoors", "NumberOfGears", "NumberOfSeats", "PermissionNeeded", "ProductionYear", "TreadCondition", "VIN" },
                values: new object[,]
                {
                    { "ABC12345", "Tesla", 0, "Electric sedan", 2, 0, 6, 0.0, null, 4, 1, null, null, null, 600.0, 500.0, "Model S", 4, 1, 5, 1, 2021, 80.0, "5YJSA1E26MF123456" },
                    { "GD9988LK", "Dacia", 2, "Affordable off-road SUV", 0, 1500, 4, 5.2999999999999998, 50.0, 1, 0, new DateTime(2024, 5, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(377), new DateTime(2024, 2, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 12, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(375), 950.0, 470.0, "Duster", 5, 5, 5, 1, 2017, 60.0, "UU1KSDMJ455123456" },
                    { "KR6789XYZ", "Mercedes-Benz", 0, "Luxury sedan", 1, 2000, 5, 4.7999999999999998, 60.0, 5, 1, new DateTime(2024, 10, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(353), new DateTime(2024, 8, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(354), new DateTime(2024, 7, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(352), 1100.0, 480.0, "C-Class", 4, 9, 5, 1, 2021, 90.0, "WDD2050741F123456" },
                    { "PL1234ABC", "Volkswagen", 1, "Popular compact car", 0, 1600, 5, 5.5, 50.0, 1, 0, new DateTime(2024, 9, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 6, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(345), new DateTime(2024, 3, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(295), 900.0, 450.0, "Golf", 5, 6, 5, 1, 2020, 80.0, "WVWZZZ1KZ6P123456" },
                    { "PO1122RT", "Tesla", 0, "Electric car", 2, 0, 6, 0.0, null, 4, 1, new DateTime(2024, 9, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(369), null, null, 560.0, 430.0, "Model 3", 4, 1, 5, 1, 2022, 85.0, "5YJ3E1EA7KF123456" },
                    { "WA4455GH", "Mazda", 2, "Mid-size SUV", 2, 2200, 5, 7.2000000000000002, 58.0, 1, 1, new DateTime(2024, 6, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(362), new DateTime(2024, 4, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(363), new DateTime(2024, 1, 28, 19, 2, 29, 970, DateTimeKind.Local).AddTicks(360), 800.0, 500.0, "CX-5", 5, 6, 5, 1, 2018, 75.0, "JMZKF1W1A01234567" },
                    { "XYZ98765", "Honda", 1, "Compact car", 0, 1800, 5, 6.5, 45.0, 0, 0, null, null, null, 700.0, 400.0, "Civic", 5, 6, 5, 1, 2019, 70.0, "1HGEM21901L123456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_DriverId",
                table: "Rentals",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_RegistrationNumber",
                table: "Rentals",
                column: "RegistrationNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
