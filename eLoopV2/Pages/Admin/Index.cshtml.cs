using System.Collections.Generic;
using eLoopV2.Data;
using eLoopV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eLoopV2.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly IElectricCarRepository _electricCarRepository;

        public IndexModel(IElectricCarRepository electricCarRepository)
        {
            _electricCarRepository = electricCarRepository;
        }

        public List<ElectricCar> ElectricCars { get; set; }

        public void OnGet()
        {
            ElectricCars = (List<ElectricCar>)_electricCarRepository.GetAllElectricCars();
        }

        public IActionResult OnPostDelete(int id)
        {
            _electricCarRepository.DeleteElectricCar(id);
            return RedirectToPage("/Admin/Index");
        }
    }
}
