/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eLoopV2.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

/*using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLoopV2.Data;
using eLoopV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace eLoopV2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ElectricCarRepository _electricCarRepository;
        private readonly ElectricCarLeaseContext _context;

        public IndexModel(ElectricCarRepository electricCarRepository, ElectricCarLeaseContext context)
        {
            _electricCarRepository = electricCarRepository;
            _context = context;
        }

        public IList<ElectricCar> ElectricCars { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public void OnGet(string searchString)
        {
            IQueryable<ElectricCar> electricCarsQuery = from car in _context.ElectricCars
                                                        select car;

            if (!string.IsNullOrEmpty(searchString))
            {
                electricCarsQuery = electricCarsQuery.Where(car =>
                    car.Make.Contains(searchString) || car.Model.Contains(searchString) ||
                    car.Color.Contains(searchString) || car.VIN.Contains(searchString) ||
                    car.PlateNumber.Contains(searchString));
            }

            ElectricCars = electricCarsQuery.ToList();
        }

    }
}

*/