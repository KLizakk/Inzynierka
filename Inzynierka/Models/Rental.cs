using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inzynierka.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        [Required]
        [ForeignKey("Car")]
        public string RegistrationNumber { get; set; }
        public virtual Car Car { get; set; }
        [Required]
        public DateTime StartDate { get; set; }

        
        public DateTime? EndDate { get; set; }

        public string? Notes { get; set; }
        // Nawigacja do relacji
       
    }
}
