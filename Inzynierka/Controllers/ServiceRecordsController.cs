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
    public class ServiceRecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceRecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceRecords
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServiceRecords.ToListAsync());
        }

        // GET: ServiceRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRecords = await _context.ServiceRecords
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (serviceRecords == null)
            {
                return NotFound();
            }

            return View(serviceRecords);
        }

        // GET: ServiceRecords/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,VehicleId,ServiceDate,ServiceType,Description")] ServiceRecords serviceRecords)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceRecords);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceRecords);
        }

        // GET: ServiceRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRecords = await _context.ServiceRecords.FindAsync(id);
            if (serviceRecords == null)
            {
                return NotFound();
            }
            return View(serviceRecords);
        }

        // POST: ServiceRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ServiceId,VehicleId,ServiceDate,ServiceType,Description")] ServiceRecords serviceRecords)
        {
            if (id != serviceRecords.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceRecords);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceRecordsExists(serviceRecords.ServiceId))
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
            return View(serviceRecords);
        }

        // GET: ServiceRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceRecords = await _context.ServiceRecords
                .FirstOrDefaultAsync(m => m.ServiceId == id);
            if (serviceRecords == null)
            {
                return NotFound();
            }

            return View(serviceRecords);
        }

        // POST: ServiceRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceRecords = await _context.ServiceRecords.FindAsync(id);
            if (serviceRecords != null)
            {
                _context.ServiceRecords.Remove(serviceRecords);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceRecordsExists(int id)
        {
            return _context.ServiceRecords.Any(e => e.ServiceId == id);
        }
    }
}
