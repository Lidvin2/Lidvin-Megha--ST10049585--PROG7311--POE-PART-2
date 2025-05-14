using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROG7311_POEPART2.Data;
using PROG7311_POEPART2.Models;

namespace PROG7311_POEPART2.Controllers
{
    public class FarmerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FarmerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "FarmerRole")]
        public async Task<IActionResult> Index()
        {
            var farmers = await _context.Farmers.ToListAsync();
            return View(farmers);
        }

        [Authorize(Roles = "FarmerRole")]
        public IActionResult Approve()
        {
            return View();
        }

        [Authorize(Roles = "FarmerRole")]
        [HttpPost]
        public async Task<IActionResult> Approve(Farmer farmer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(farmer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(farmer);
        }

        [Authorize(Roles = "FarmerRole")]
        public async Task<IActionResult> Reject(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmers.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }

            _context.Farmers.Remove(farmer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "FarmerRole")]
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmer = await _context.Farmers.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }
            return View(farmer);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, Farmer farmer)
        {
            if (id != farmer.FarmerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(farmer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(farmer);
        }
    }
}
