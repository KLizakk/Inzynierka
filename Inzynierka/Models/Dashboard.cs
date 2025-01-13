namespace Inzynierka.Models

{
    public class DashboardViewModel
    {
        public string FullName { get; set; }
        public int TotalCars { get; set; } // Liczba wszystkich pojazdów
        public int CarsInUse { get; set; } // Liczba pojazdów w użyciu
        public int CarsNeedingMaintenance { get; set; } // Pojazdy wymagające przeglądu lub ubezpieczenia
        public List<Rental> Rentals { get; set; } = new List<Rental>();
        public List<ActivityLogViewModel> RecentActivities { get; set; } = new List<ActivityLogViewModel>();
    }

    public class ActivityLogViewModel
    {
        public DateTime Date { get; set; }
        public string CarModel { get; set; }
        public string CarRegistrationNumber { get; set; }
        public string Action { get; set; } // Np. "Wypożyczony", "Zwrócony"
        public string DriverName { get; set; }
    }
}
