using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inzynierka.Models
{
    public class Car
    {
        [Key]
        [Required(ErrorMessage = "Registration number is required.")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Model is required.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Brand is required.")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "VIN is required.")]
        public string VIN { get; set; }

        [Required(ErrorMessage = "Permission needed is required.")]
        public PermissionNeeded? PermissionNeeded { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string? Description { get; set; }

        public bool IsRented { get; set; }
        //Pomocnicze
        [NotMapped]
        public int? DaysUntilNextTechnicalReview => LastTechnicalReview.HasValue
        ? (LastTechnicalReview.Value.AddYears(1) - DateTime.Now).Days
        : (int?)null;

        [NotMapped]
        public int? DaysUntilNextInsurance => LastInsurance.HasValue
        ? (LastInsurance.Value.AddYears(1) - DateTime.Now).Days
        : (int?)null;

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
