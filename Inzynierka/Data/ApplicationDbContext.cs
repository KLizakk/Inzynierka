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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
