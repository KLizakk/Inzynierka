using Microsoft.AspNetCore.Mvc;
using Inzynierka.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Data;

namespace Inzynierka.Controllers
{
    public class RentalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Rental/Create
        public IActionResult Create()
        {
            ViewBag.Drivers = _context.Drivers.ToList();
            ViewBag.Cars = _context.Cars.ToList();
            return View();
        }

        // POST: Rental/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DriverId,RegistrationNumber,StartDate,EndDate,Notes")] Rental rental)
        {
            rental.Car = _context.Cars.Find(rental.RegistrationNumber);
            rental.Driver = _context.Drivers.Find(rental.DriverId);

            if(rental.Car == null || rental.Driver == null)
            {
                ViewBag.Drivers = _context.Drivers.ToList();
                ViewBag.Cars = _context.Cars.ToList();
                return View(rental);
            }

            else{ 
             _context.Add(rental);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            }
            
            
        }

        // GET: Rental/Index
        public async Task<IActionResult> Index()
        {
            var rentals = await _context.Rentals.Include(r => r.Driver).Include(r => r.Car).ToListAsync();
            return View(rentals);
        }
    }
}