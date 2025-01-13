using Inzynierka.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models;
using Inzynierka.Data;

namespace YourNamespace.Controllers
{
    [Authorize]
    public class DriverController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public DriverController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Wyświetlanie szczegółów zalogowanego kierowcy
        public async Task<IActionResult> Profile()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
                return NotFound();

            var driver = await _context.Drivers
                .Include(d => d.Rentals) // Załaduj powiązane wypożyczenia
                    .ThenInclude(r => r.Car) // Załaduj szczegóły samochodów
                .FirstOrDefaultAsync(d => d.UserId == userId);

            if (driver == null)
                return NotFound();

            return View(driver);
        }

        // Edycja danych kierowcy
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
                return NotFound();

            var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.UserId == userId);
            if (driver == null)
                return NotFound();

            return View(driver);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Driver driver)
        {
            if (!ModelState.IsValid)
                return View(driver);

            var userId = _userManager.GetUserId(User);
            var existingDriver = await _context.Drivers.FirstOrDefaultAsync(d => d.UserId == userId);

            if (existingDriver == null)
                return NotFound();

            existingDriver.FirstName = driver.FirstName;
            existingDriver.LastName = driver.LastName;
            existingDriver.PhoneNumber = driver.PhoneNumber;
            existingDriver.DateOfBirth = driver.DateOfBirth;

            _context.Update(existingDriver);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Profile));
        }

        [HttpGet]
        public async Task<IActionResult> ReturnCar(int rentalId)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
                return Unauthorized();

            var rental = await _context.Rentals
                .Include(r => r.Car)
                .FirstOrDefaultAsync(r => r.Id == rentalId && r.Driver.UserId == userId);

            if (rental == null)
                return NotFound();

            if (rental.EndDate.HasValue)
                return BadRequest("Ten wynajem został już zakończony.");

            return View(rental);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReturnCar(int rentalId, double distanceTraveled)
        {
            var userId = _userManager.GetUserId(User);
            var driver = await _context.Drivers.FirstOrDefaultAsync(d => d.UserId == userId);
            if (userId == null)
                return Unauthorized();

            var rental = await _context.Rentals
                .Include(r => r.Car)
                .FirstOrDefaultAsync(r => r.Id == rentalId && r.Driver.UserId == userId);

            if (rental == null)
                return NotFound();

            if (rental.EndDate.HasValue)
                return BadRequest("Ten wynajem został już zakończony.");

            if (distanceTraveled <= 0)
                return BadRequest("Dystans przejechany musi być większy od zera.");

            rental.DistanceTraveled = distanceTraveled;
            rental.EndDate = DateTime.Now;
            driver.IsBusy = false;

            _context.Update(rental);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Profile));
        }


    }
}
