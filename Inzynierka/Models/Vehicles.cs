using System.ComponentModel.DataAnnotations;

namespace Inzynierka.Models
{
    public class Vehicles
    {
        [Key] 
        public int VehicleId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string VIN { get; set; }
        public string EngineNumber { get; set; }
        public int ProductionYear { get; set; }
        public string EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public string Power { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }
        public string Notes { get; set; }
    }
}
