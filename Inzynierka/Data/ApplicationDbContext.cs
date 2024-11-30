using Inzynierka.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inzynierka.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Car> Cars { get; set; }
        public DbSet<Models.Driver> Drivers { get; set; }
        public DbSet<Models.Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seeding kierowców
            // Seeding kierowców
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    DriverId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNumber = "123456789",
                    DateOfBirth = new DateTime(1985, 5, 12),
                    IsBusy = false,
                    PermissionNeeded = new List<PermissionNeeded> { PermissionNeeded.B }
                },
                new Driver
                {
                    DriverId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    PhoneNumber = "987654321",
                    DateOfBirth = new DateTime(1990, 8, 23),
                    IsBusy = false,
                    PermissionNeeded = new List<PermissionNeeded> { PermissionNeeded.B, PermissionNeeded.E }
                },
                new Driver
                {
                    DriverId = 3,
                    FirstName = "Robert",
                    LastName = "Johnson",
                    PhoneNumber = "555666777",
                    DateOfBirth = new DateTime(1978, 3, 18),
                    IsBusy = false,
                    PermissionNeeded = new List<PermissionNeeded> { PermissionNeeded.C }
                },
                new Driver
                {
                    DriverId = 4,
                    FirstName = "Emily",
                    LastName = "Davis",
                    PhoneNumber = "222333444",
                    DateOfBirth = new DateTime(1995, 11, 5),
                    IsBusy = false,
                    PermissionNeeded = new List<PermissionNeeded> { PermissionNeeded.B, PermissionNeeded.D }
                },
                new Driver
                {
                    DriverId = 5,
                    FirstName = "Michael",
                    LastName = "Wilson",
                    PhoneNumber = "111222333",
                    DateOfBirth = new DateTime(1980, 7, 29),
                    IsBusy = false,
                    PermissionNeeded = new List<PermissionNeeded> { PermissionNeeded.T }
                }
            );

            modelBuilder.Entity<Rental>()
        .HasOne(r => r.Driver)
        .WithMany(d => d.Rentals)
        .HasForeignKey(r => r.DriverId);

            modelBuilder.Entity<Rental>()
                .HasOne(r => r.Car)
                .WithMany(c => c.Rentals)
                .HasForeignKey(r => r.RegistrationNumber);
            modelBuilder.Entity<Models.Car>().HasData(
             new Models.Car()
             {
                 RegistrationNumber = "ABC12345",
                 Model = "Model S",
                 Brand = "Tesla",
                 VIN = "5YJSA1E26MF123456",
                 PermissionNeeded = PermissionNeeded.B,
                 Description = "Electric sedan",
                 ProductionYear = 2021,
                 EngineCapacity = 0,
                 CarType = CarType.Sedan,
                 ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Other,
                 FuelType = FuelType.Electric,
                 GearboxType = GearboxType.Automatic,
                 DriveType = Models.DriveType.AWD,
                 NumberOfSeats = 5,
                 NumberOfDoors = 4,
                 NumberOfGears = 1,
                 LastTechnicalReview = null,
                 LastInsurance = null,
                 LastOilChange = null,
                 FuelConsumption = 0,
                 FuelTankCapacity = null,
                 MaxDistance = 600,
                 MaxLoad = 500,
                 TreadCondition = 80

             },
             new Car
             {
                 RegistrationNumber = "XYZ98765",
                 Model = "Civic",
                 Brand = "Honda",
                 VIN = "1HGEM21901L123456",
                 PermissionNeeded = PermissionNeeded.B,
                 Description = "Compact car",
                 ProductionYear = 2019,
                 EngineCapacity = 1800,
                 CarType = CarType.Hatchback,
                 ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Euro6,
                 FuelType = FuelType.Petrol,
                 GearboxType = GearboxType.Manual,
                 DriveType = Models.DriveType.FWD,
                 NumberOfSeats = 5,
                 NumberOfDoors = 5,
                 NumberOfGears = 6,
                 LastTechnicalReview = null,
                 LastInsurance = null,
                 LastOilChange = null,
                 FuelConsumption = 6.5,
                 FuelTankCapacity = 45,
                 MaxDistance = 700,
                 MaxLoad = 400,
                 TreadCondition = 70
             },
             new Car
             {
                 RegistrationNumber = "PL1234ABC",
                 Model = "Golf",
                 Brand = "Volkswagen",
                 VIN = "WVWZZZ1KZ6P123456",
                 PermissionNeeded = PermissionNeeded.B,
                 Description = "Popular compact car",
                 ProductionYear = 2020,
                 EngineCapacity = 1600,
                 CarType = CarType.Hatchback,
                 ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Euro6,
                 FuelType = FuelType.Diesel,
                 GearboxType = GearboxType.Manual,
                 DriveType = Models.DriveType.FWD,
                 NumberOfSeats = 5,
                 NumberOfDoors = 5,
                 NumberOfGears = 6,
                 LastTechnicalReview = DateTime.Now.AddMonths(-8),
                 LastInsurance = DateTime.Now.AddMonths(-2),
                 LastOilChange = DateTime.Now.AddMonths(-5),
                 FuelConsumption = 5.5,
                 FuelTankCapacity = 50,
                 MaxDistance = 900,
                 MaxLoad = 450,
                 TreadCondition = 80
             },
             new Car
             {
                 RegistrationNumber = "KR6789XYZ",
                 Model = "C-Class",
                 Brand = "Mercedes-Benz",
                 VIN = "WDD2050741F123456",
                 PermissionNeeded = PermissionNeeded.B,
                 Description = "Luxury sedan",
                 ProductionYear = 2021,
                 EngineCapacity = 2000,
                 CarType = CarType.Sedan,
                 ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Euro6,
                 FuelType = FuelType.Hybrid,
                 GearboxType = GearboxType.Automatic,
                 DriveType = Models.DriveType.RWD,
                 NumberOfSeats = 5,
                 NumberOfDoors = 4,
                 NumberOfGears = 9,
                 LastTechnicalReview = DateTime.Now.AddMonths(-4),
                 LastInsurance = DateTime.Now.AddMonths(-1),
                 LastOilChange = DateTime.Now.AddMonths(-3),
                 FuelConsumption = 4.8,
                 FuelTankCapacity = 60,
                 MaxDistance = 1100,
                 MaxLoad = 480,
                 TreadCondition = 90
             },

new Car
{
    RegistrationNumber = "WA4455GH",
    Model = "CX-5",
    Brand = "Mazda",
    VIN = "JMZKF1W1A01234567",
    PermissionNeeded = PermissionNeeded.B,
    Description = "Mid-size SUV",
    ProductionYear = 2018,
    EngineCapacity = 2200,
    CarType = CarType.SUV,
    ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Euro6,
    FuelType = FuelType.Diesel,
    GearboxType = GearboxType.Automatic,
    DriveType = Models.DriveType.AWD,
    NumberOfSeats = 5,
    NumberOfDoors = 5,
    NumberOfGears = 6,
    LastTechnicalReview = DateTime.Now.AddMonths(-10),
    LastInsurance = DateTime.Now.AddMonths(-5),
    LastOilChange = DateTime.Now.AddMonths(-7),
    FuelConsumption = 7.2,
    FuelTankCapacity = 58,
    MaxDistance = 800,
    MaxLoad = 500,
    TreadCondition = 75
},

new Car
{
    RegistrationNumber = "PO1122RT",
    Model = "Model 3",
    Brand = "Tesla",
    VIN = "5YJ3E1EA7KF123456",
    PermissionNeeded = PermissionNeeded.B,
    Description = "Electric car",
    ProductionYear = 2022,
    EngineCapacity = 0,
    CarType = CarType.Sedan,
    ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Other,
    FuelType = FuelType.Electric,
    GearboxType = GearboxType.Automatic,
    DriveType = Models.DriveType.AWD,
    NumberOfSeats = 5,
    NumberOfDoors = 4,
    NumberOfGears = 1,
    LastTechnicalReview = null,
    LastInsurance = DateTime.Now.AddMonths(-2),
    LastOilChange = null,
    FuelConsumption = 0,
    FuelTankCapacity = null,
    MaxDistance = 560,
    MaxLoad = 430,
    TreadCondition = 85
},

new Car
{
    RegistrationNumber = "GD9988LK",
    Model = "Duster",
    Brand = "Dacia",
    VIN = "UU1KSDMJ455123456",
    PermissionNeeded = PermissionNeeded.B,
    Description = "Affordable off-road SUV",
    ProductionYear = 2017,
    EngineCapacity = 1500,
    CarType = CarType.SUV,
    ExhaustGasEmissionCategory = ExhaustGasEmissionCategory.Euro5,
    FuelType = FuelType.Diesel,
    GearboxType = GearboxType.Manual,
    DriveType = Models.DriveType.FWD,
    NumberOfSeats = 5,
    NumberOfDoors = 5,
    NumberOfGears = 5,
    LastTechnicalReview = DateTime.Now.AddMonths(-11),
    LastInsurance = DateTime.Now.AddMonths(-6),
    LastOilChange = DateTime.Now.AddMonths(-9),
    FuelConsumption = 5.3,
    FuelTankCapacity = 50,
    MaxDistance = 950,
    MaxLoad = 470,
    TreadCondition = 60
}
                );

        }

    }
}
