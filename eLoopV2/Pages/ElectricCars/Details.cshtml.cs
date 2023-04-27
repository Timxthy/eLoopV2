using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLoopV2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using eLoopV2.Models;

namespace eLoopV2.Pages.ElectricCars
{
    public class DetailsModel : PageModel
    {
        private readonly ElectricCarLeaseContext _context;

        public DetailsModel(ElectricCarLeaseContext context)
        {
            _context = context;
        }

        public ElectricCar ElectricCar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ElectricCar = await _context.ElectricCars
                .Include(e => e.Location).FirstOrDefaultAsync(m => m.ID == id);

            if (ElectricCar == null)
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public Reservation Reservation { get; set; }

        public bool IsAuthenticated
        {
            get
            {
                return User.Identity.IsAuthenticated;
            }
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ElectricCar = await _context.ElectricCars
                .Include(e => e.Location).FirstOrDefaultAsync(m => m.ID == id);

            if (ElectricCar == null)
            {
                return NotFound();
            }

            if (!ElectricCar.IsAvailable)
            {
                ModelState.AddModelError("", "This car is already reserved.");
                return Page();
            }

            Reservation.Car = ElectricCar;
            _context.Reservations.Add(Reservation);
            ElectricCar.IsAvailable = false;

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
