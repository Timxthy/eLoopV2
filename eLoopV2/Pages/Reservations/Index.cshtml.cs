using System.Threading.Tasks;
using eLoopV2.Data;
using eLoopV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace eLoopV2.Pages.Reservations
{
    public class ReservationModel : PageModel
    {
        private readonly ElectricCarLeaseContext _context;

        public ReservationModel(ElectricCarLeaseContext context)
        {
            _context = context;
        }

        public Reservation Reservation { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Reservation = await _context.Reservations
                .Include(r => r.Car)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Reservation == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
