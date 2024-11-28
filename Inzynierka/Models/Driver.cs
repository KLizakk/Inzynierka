using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inzynierka.Models
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public List<PermissionNeeded>? PermissionNeeded { get; set; } = new List<PermissionNeeded>();
        
        // Lista wypożyczeń kierowcy
        public List<Rental>? Rentals { get; set; } = new List<Rental>();

    }
}
