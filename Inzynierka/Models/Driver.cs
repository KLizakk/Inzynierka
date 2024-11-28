namespace Inzynierka.Models
{
    public class Driver
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public static string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        

    }
}
