using eLoopV2.Data;
using eLoopV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLoopV2.Pages
{
    public class LeaseModel : PageModel
    {
        private readonly ElectricCarLeaseContext _context;

        public LeaseModel(ElectricCarLeaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lease Lease { get; set; }

        public IList<ElectricCar> AvailableCars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lease = await _context.Leases.FirstOrDefaultAsync(m => m.Id == id);

            if (Lease == null)
            {
                return NotFound();
            }

            // Get all available cars
            AvailableCars = await _context.ElectricCars.Where(c => c.IsAvailable == true).ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Update the availability of the car
            var car = await _context.ElectricCars.FindAsync(Lease.CarId);
            car.IsAvailable = false;
            _context.Attach(car).State = EntityState.Modified;

            // Save the lease
            _context.Leases.Add(Lease);
            await _context.SaveChangesAsync();

            return RedirectToPage("./LeaseConfirmation", new { id = Lease.Id });
        }
    }
}
