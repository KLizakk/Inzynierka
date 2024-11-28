using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inzynierka.Data;
using Inzynierka.Models;

namespace Inzynierka.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.RegistrationNumber == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
        private SelectList GetSelectList<T>() where T : Enum
        {
            return new SelectList(Enum.GetValues(typeof(T)).Cast<T>().Select(e => new { Value = e, Text = e.ToString() }), "Value", "Text");
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            ViewBag.CarTypeList = GetSelectList<CarType>();
            ViewBag.ExhaustGasEmissionCategoryList = GetSelectList<ExhaustGasEmissionCategory>();
            ViewBag.FuelTypeList = GetSelectList<FuelType>();
            ViewBag.GearboxTypeList = GetSelectList<GearboxType>();
            ViewBag.DriveTypeList = GetSelectList<Models.DriveType>();
            ViewBag.PermissionNeededList = GetSelectList<PermissionNeeded>();
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistrationNumber,Model,Brand,VIN,PermissionNeeded,Description,ProductionYear,EngineCapacity,CarType,ExhaustGasEmissionCategory,FuelType,GearboxType,DriveType,NumberOfSeats,NumberOfDoors,NumberOfGears,LastTechnicalReview,LastInsurance,LastOilChange,FuelConsumption,FuelTankCapacity,MaxDistance,MaxLoad,TreadCondition")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Odtwórz listy w przypadku błędu walidacji
            ViewBag.CarTypeList = GetSelectList<CarType>();
            ViewBag.ExhaustGasEmissionCategoryList = GetSelectList<ExhaustGasEmissionCategory>();
            ViewBag.FuelTypeList = GetSelectList<FuelType>();
            ViewBag.GearboxTypeList = GetSelectList<GearboxType>();
            ViewBag.DriveTypeList = GetSelectList<Models.DriveType>();
            ViewBag.PermissionNeededList = GetSelectList<PermissionNeeded>();
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            ViewBag.CarTypeList = GetSelectList<CarType>();
            ViewBag.ExhaustGasEmissionCategoryList = GetSelectList<ExhaustGasEmissionCategory>();
            ViewBag.FuelTypeList = GetSelectList<FuelType>();
            ViewBag.GearboxTypeList = GetSelectList<GearboxType>();
            ViewBag.DriveTypeList = GetSelectList<Models.DriveType>();
            ViewBag.PermissionNeededList = GetSelectList<PermissionNeeded>();
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RegistrationNumber,Model,Brand,VIN,PermissionNeeded,Description,ProductionYear,EngineCapacity,CarType,ExhaustGasEmissionCategory,FuelType,GearboxType,DriveType,NumberOfSeats,NumberOfDoors,NumberOfGears,LastTechnicalReview,LastInsurance,LastOilChange,FuelConsumption,FuelTankCapacity,MaxDistance,MaxLoad,TreadCondition")] Car car)
        {
            if (id != car.RegistrationNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.RegistrationNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CarTypeList = GetSelectList<CarType>();
            ViewBag.ExhaustGasEmissionCategoryList = GetSelectList<ExhaustGasEmissionCategory>();
            ViewBag.FuelTypeList = GetSelectList<FuelType>();
            ViewBag.GearboxTypeList = GetSelectList<GearboxType>();
            ViewBag.DriveTypeList = GetSelectList<Models.DriveType>();
            ViewBag.PermissionNeededList = GetSelectList<PermissionNeeded>();
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.RegistrationNumber == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(string id)
        {
            return _context.Cars.Any(e => e.RegistrationNumber == id);
        }
    }
}
