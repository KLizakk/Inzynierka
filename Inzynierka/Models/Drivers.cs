using System.ComponentModel.DataAnnotations;

namespace Inzynierka.Models
{
    public class Drivers
    {
        [Key]
        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
    }
}
