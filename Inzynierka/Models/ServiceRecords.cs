using System.ComponentModel.DataAnnotations;

namespace Inzynierka.Models
{
    public class ServiceRecords
    {
        [Key]
        public int ServiceId { get; set; }
        public int VehicleId { get; set; }
        public string ServiceDate { get; set; }
        public string ServiceType { get; set; }
        
        public string Description { get; set; }
    }
}
