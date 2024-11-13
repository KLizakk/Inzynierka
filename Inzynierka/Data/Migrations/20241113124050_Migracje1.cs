using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inzynierka.Data.Migrations
{
    /// <inheritdoc />
    public partial class Migracje1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRecords",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    ServiceDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRecords", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionYear = table.Column<int>(type: "int", nullable: false),
                    EngineCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            // Wstawienie przykładowych danych do tabeli Drivers
            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverId", "FirstName", "LastName", "Pesel", "Address", "PhoneNumber", "Email", "Notes" },
                values: new object[,]
                {
            { 1, "Jan", "Kowalski", "90010112345", "Warszawa, ul. Przykładowa 1", "123456789", "jan.kowalski@example.com", "Doświadczony kierowca" },
            { 2, "Anna", "Nowak", "91020223456", "Kraków, ul. Centralna 10", "234567890", "anna.nowak@example.com", "Specjalista od długich tras" },
            { 3, "Piotr", "Wiśniewski", "92030334567", "Łódź, ul. Leśna 5", "345678901", "piotr.wisniewski@example.com", "Przepisowy kierowca" },
            { 4, "Ewa", "Wójcik", "93040445678", "Wrocław, ul. Zielona 2", "456789012", "ewa.wojcik@example.com", "Odpowiedzialna kierowczyni" },
            { 5, "Tomasz", "Kamiński", "94050556789", "Poznań, ul. Słoneczna 4", "567890123", "tomasz.kaminski@example.com", "Kierowca ciężarówek" },
            { 6, "Katarzyna", "Lewandowska", "95060667890", "Gdańsk, ul. Rzeczna 8", "678901234", "katarzyna.lewandowska@example.com", "Specjalistka od jazdy w trudnych warunkach" },
            { 7, "Marcin", "Zieliński", "96070778901", "Szczecin, ul. Górna 7", "789012345", "marcin.zielinski@example.com", "Punktualny kierowca" },
            { 8, "Agata", "Szymańska", "97080889012", "Katowice, ul. Dolna 9", "890123456", "agata.szymanska@example.com", "Bez wypadków" },
            { 9, "Paweł", "Woźniak", "98090990123", "Lublin, ul. Krótka 3", "901234567", "pawel.wozniak@example.com", "Ekspert od ekonomicznej jazdy" },
            { 10, "Zofia", "Dąbrowska", "99010101234", "Bydgoszcz, ul. Nowa 11", "123456780", "zofia.dabrowska@example.com", "Ostrożna kierowczyni" }
                });

            // Wstawienie przykładowych danych do tabeli Vehicles
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "Brand", "Model", "RegistrationNumber", "VIN", "EngineNumber", "ProductionYear", "EngineCapacity", "FuelType", "Power", "Color", "Owner", "Notes" },
                values: new object[,]
                {
            { 1, "Toyota", "Corolla", "WW1234X", "JTDBR32E330052345", "EN123456", 2015, "1.8L", "Benzyna", "140KM", "Srebrny", "Jan Kowalski", "Auto w dobrym stanie" },
            { 2, "Ford", "Focus", "KR5678Y", "WF0AXXWPDA5J45456", "EN654321", 2018, "2.0L", "Diesel", "150KM", "Niebieski", "Anna Nowak", "Bez uszkodzeń" },
            { 3, "Volkswagen", "Golf", "LD9123Z", "WV1ZZZ7HZJY123456", "EN789012", 2017, "1.6L", "Benzyna", "120KM", "Czarny", "Piotr Wiśniewski", "Używany na krótkie dystanse" },
            { 4, "BMW", "3 Series", "PO3456A", "WBA8E1C57JK123456", "EN345678", 2019, "2.0L", "Benzyna", "184KM", "Biały", "Ewa Wójcik", "Regularnie serwisowany" },
            { 5, "Audi", "A4", "GD6789B", "WAUZR8DZ7GA123456", "EN901234", 2016, "1.8L", "Diesel", "150KM", "Czerwony", "Tomasz Kamiński", "Wymaga przeglądu" },
            { 6, "Mercedes", "C-Class", "SZ1234C", "WDD2050031F123456", "EN567890", 2020, "2.2L", "Benzyna", "194KM", "Szary", "Katarzyna Lewandowska", "Doskonały stan techniczny" },
            { 7, "Opel", "Astra", "KT5678D", "WOLOXCF0832145678", "EN345678", 2014, "1.4L", "Benzyna", "100KM", "Zielony", "Marcin Zieliński", "Bez kolizji" },
            { 8, "Mazda", "6", "SK9123E", "JMZGL6G7721234567", "EN678901", 2015, "2.0L", "Diesel", "165KM", "Brązowy", "Agata Szymańska", "Auto po przeglądzie" },
            { 9, "Hyundai", "i30", "LU3456F", "KMHDU4AD4AU123456", "EN012345", 2021, "1.6L", "Benzyna", "136KM", "Błękitny", "Paweł Woźniak", "Nowy samochód" },
            { 10, "Renault", "Megane", "BY6789G", "VF1BZC2A2G5245678", "EN234567", 2013, "1.5L", "Diesel", "110KM", "Żółty", "Zofia Dąbrowska", "Ekonomiczny" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
