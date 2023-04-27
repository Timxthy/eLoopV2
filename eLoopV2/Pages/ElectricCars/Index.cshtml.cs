using eLoopV2.Data;
using eLoopV2.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace eLoopV2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ElectricCarLeaseContext _context;

        public IndexModel(ElectricCarLeaseContext context)
        {
            _context = context;
        }

        public IList<ElectricCar> ElectricCars { get; set; }

        public void OnGet()
        {
            ElectricCars = _context.ElectricCars
                .Where(car => car.IsAvailable == true)
                .ToList();
        }
    }
}
