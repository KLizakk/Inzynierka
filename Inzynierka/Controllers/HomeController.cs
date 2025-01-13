using Inzynierka.Data;
using Inzynierka.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Inzynierka.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                // Przypisz dane do modelu, np. z bazy danych
                Rentals = _context.Rentals.Include(r => r.Car).Include(r => r.Driver).ToList(),
                TotalCars = _context.Cars.Count(),
                CarsInUse = _context.Rentals.Count(r => r.EndDate == null),
               
            };
            model.RecentActivities = model.Rentals
                .OrderByDescending(r => r.StartDate)
                .Take(5)
                .Select(r => new ActivityLogViewModel
                {
                    Date = r.StartDate,
                    CarModel = r.Car.Model,
                    CarRegistrationNumber = r.Car.RegistrationNumber,
                    Action = r.EndDate == null ? "Wypo¿yczony" : "Zwrócony",
                    DriverName = r.Driver.FullName
                })
                .ToList();

            return View(model);
        }

         
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
