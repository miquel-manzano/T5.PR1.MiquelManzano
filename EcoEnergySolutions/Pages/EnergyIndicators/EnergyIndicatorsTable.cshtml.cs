using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class EnergyIndicatorsTableModel : PageModel
    {
        public List<EnergyIndicator> EnergyIndicatorsList { get; set; }
        public void OnGet()
        {
            using var dbContext = new ApplicationDbContext();
            EnergyIndicatorsList = new List<EnergyIndicator>();

            EnergyIndicatorsList = dbContext.EnergyIndicators.ToList();
        }
    }
}
