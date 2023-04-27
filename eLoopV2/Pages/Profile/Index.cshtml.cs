using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using eLoopV2.Data;
using eLoopV2.Models;

namespace eLoopV2.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ElectricCarLeaseContext _context;

        public ProfileModel(ElectricCarLeaseContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
