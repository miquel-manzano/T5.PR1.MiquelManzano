using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.WaterConsumptions
{
    public class AddWaterConsumptionModel : PageModel
    {
        [BindProperty]
        public WaterConsumption NewEntry { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            using var dbContext = new ApplicationDbContext();

            dbContext.WaterConsumptions.Add(NewEntry);
            dbContext.SaveChanges();
            return RedirectToPage("/WaterConsumptions/WaterConsumptionsTable");
        }
    }
}
