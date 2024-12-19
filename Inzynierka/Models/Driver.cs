using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
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

        public bool IsBusy { get; set; }
        // Przypisany użytkownik
        [ForeignKey("User")]
        public string? UserId { get; set; } // Klucz obcy do IdentityUser
        public IdentityUser? User { get; set; } // Nawigacja do użytkownika
    }
}
