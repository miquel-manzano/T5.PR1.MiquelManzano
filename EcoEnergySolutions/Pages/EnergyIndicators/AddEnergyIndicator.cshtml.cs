using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class AddEnergyIndicatorModel : PageModel
    {
        [BindProperty]
        public EnergyIndicator? NewEntry { get; set; }


        public IActionResult OnPost()
        {
            using var dbContext = new ApplicationDbContext();
            
            dbContext.EnergyIndicators.Add(NewEntry);
            dbContext.SaveChanges();
            return RedirectToPage("/EnergyIndicators/EnergyIndicatorsTable");
        }
    }
}
