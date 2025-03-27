using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class AddEnergyIndicatorModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public AddEnergyIndicatorModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EnergyIndicator? NewEntry { get; set; }

        public IActionResult OnPost()
        {
            _context.EnergyIndicators.Add(NewEntry);
            _context.SaveChanges();
            return RedirectToPage("/EnergyIndicators/EnergyIndicatorsTable");
        }
    }
}
