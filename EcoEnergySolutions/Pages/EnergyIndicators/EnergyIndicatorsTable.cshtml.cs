using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class EnergyIndicatorsTableModel : PageModel
    {
        public List<EnergyIndicator> EnergyIndicatorsList { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            using var dbContext = new ApplicationDbContext();
            EnergyIndicatorsList = new List<EnergyIndicator>();

            if (dbContext.EnergyIndicators.IsNullOrEmpty())
            {
                Message = "No data found...";
            }
            else
            {
                EnergyIndicatorsList = dbContext.EnergyIndicators.ToList();
            }            
        }
    }
}
