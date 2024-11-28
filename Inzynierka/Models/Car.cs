using System.ComponentModel.DataAnnotations;

namespace Inzynierka.Models
{
    public class Car
    {
        [Key]
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string VIN { get; set; }
        public PermissionNeeded? PermissionNeeded { get; set; }
        public string? Description { get; set; }


        // Szczegóły


        public int? ProductionYear { get; set; }
        public int? EngineCapacity { get; set; }
        public CarType? CarType { get; set; }
        public ExhaustGasEmissionCategory? ExhaustGasEmissionCategory { get; set; }
        public FuelType? FuelType { get; set; }
        public GearboxType? GearboxType { get; set; }
        public DriveType? DriveType { get; set; }

        public int? NumberOfSeats { get; set; }
        public int? NumberOfDoors { get; set; }
        public int? NumberOfGears { get; set; }
        public DateTime? LastTechnicalReview { get; set; }
        public DateTime? LastInsurance { get; set; }
        public DateTime? LastOilChange { get; set; }
        public double? FuelConsumption { get; set; }
        public double? FuelTankCapacity { get; set; }
        public double? MaxDistance { get; set; }
        public double? MaxLoad { get; set; }
        public double? TreadCondition { get; set; }
        // Lista wypożyczeń
        public List<Rental>? Rentals { get; set; } = new List<Rental>();
    }
    public enum CarType
    {
        Sedan,
        Hatchback,
        SUV,
        Coupe,
        Cabriolet,
        Van,
        Pickup,
        Minivan,
        Limousine,
        Other
    }

    public enum ExhaustGasEmissionCategory
    {
        Euro1,
        Euro2,
        Euro3,
        Euro4,
        Euro5,
        Euro6,
        Other
    }

    public enum FuelType
    {
        Petrol,
        Diesel,
        LPG,
        CNG,
        Electric,
        Hybrid,
        Other
    }

    public enum GearboxType
    {
        Manual,
        Automatic,
        SemiAutomatic,
        CVT,
        DCT,
        Other
    }

    public enum DriveType
    {
        FWD,
        RWD,
        AWD,
        Other
    }

    public enum PermissionNeeded
    {
        None,
        B,
        C,
        D,
        E,
        T,
        Other
    }
}
