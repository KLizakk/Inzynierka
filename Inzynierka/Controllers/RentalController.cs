using Microsoft.AspNetCore.Mvc;
using Inzynierka.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.Drivers = _context.Drivers.ToList().Where(x => x.IsBusy == false);
            ViewBag.Cars = _context.Cars.ToList().Where(x=> x.IsRented == false);
            return View();
        }

        // POST: Rental/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistrationNumber,DriverId,StartDate,EndDate,Notes")] Rental rental)
        {
            
                var car = await _context.Cars.FindAsync(rental.RegistrationNumber);
                if (car == null || car.IsRented)
                {
                    ModelState.AddModelError("", "Selected car is not available.");
                    ViewBag.Drivers = new SelectList(_context.Drivers, "DriverId", "FullName");
                    ViewBag.Cars = _context.Cars.Where(c => !c.IsRented).ToList();
                    return View(rental);
                }
                var driver = await _context.Drivers.FindAsync(rental.DriverId);
            if (driver == null || driver.IsBusy)
                {
                    ModelState.AddModelError("", "Selected driver is not avalible .");
                    ViewBag.Drivers = new SelectList(_context.Drivers, "DriverId", "FullName");
                    ViewBag.Cars = _context.Cars.Where(c => !c.IsRented).ToList();
                    return View(rental);
                }
                
                car.IsRented = true;
                driver.IsBusy = true;
                _context.Add(rental);   
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            
           
        }
        public async Task<IActionResult> ReturnCar(int rentalId)
        {
            var rental = await _context.Rentals
                .Include(r => r.Car)
                .Include(r => r.Driver)
                .FirstOrDefaultAsync(r => r.Id == rentalId);

            if (rental == null)
            {
                return NotFound();
            }

            // Ustawienie samochodu jako dostępnego
            rental.Car.IsRented = false;
            rental.Driver.IsBusy = false;
            // Zakończenie wypożyczenia
            rental.EndDate = DateTime.Now;

            // Aktualizacja bazy danych
            _context.Update(rental.Car);
            //_context.Remove(rental); // Jeśli chcesz usunąć rekord wypożyczenia, inaczej usuń tę linię
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // GET: Rental/Index
        public async Task<IActionResult> Index()
        {
            var rentals = await _context.Rentals.Include(r => r.Driver).Include(r => r.Car).ToListAsync();
            return View(rentals);
        }
    }
}