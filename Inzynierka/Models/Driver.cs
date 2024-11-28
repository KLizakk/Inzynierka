using System.ComponentModel.DataAnnotations;

namespace Inzynierka.Models
{
    public class Driver
    {
        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public static string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public List<PermissionNeeded>? PermissionNeeded { get; set; } = new List<PermissionNeeded>();

    }
}
