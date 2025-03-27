using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.WaterConsumptions
{
    public class AddWaterConsumptionModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public AddWaterConsumptionModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WaterConsumption NewEntry { get; set; }

        public IActionResult OnPost()
        {
            _context.WaterConsumptions.Add(NewEntry);
            _context.SaveChanges();
            return RedirectToPage("/WaterConsumptions/WaterConsumptionsTable");
        }
    }
}
