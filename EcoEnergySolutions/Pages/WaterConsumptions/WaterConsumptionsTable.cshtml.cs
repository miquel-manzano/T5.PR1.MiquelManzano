using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace EcoEnergySolutions.Pages.WaterConsumptions
{
    public class WaterConsumptionsTableModel : PageModel
    {
        public List<WaterConsumption> WaterConsumptionsList { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            using var dbContext = new ApplicationDbContext();
            WaterConsumptionsList = new List<WaterConsumption>();

            if (dbContext.WaterConsumptions.IsNullOrEmpty())
            {
                Message = "No data found...";
            }
            else
            {
                WaterConsumptionsList = dbContext.WaterConsumptions.ToList();
            }
        }
    }
}
