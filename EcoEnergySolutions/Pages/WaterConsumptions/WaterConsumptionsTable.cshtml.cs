using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace EcoEnergySolutions.Pages.WaterConsumptions
{
    public class WaterConsumptionsTableModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public WaterConsumptionsTableModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<WaterConsumption> WaterConsumptionsList { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            WaterConsumptionsList = new List<WaterConsumption>();

            if (_context.WaterConsumptions.IsNullOrEmpty())
            {
                Message = "No data found...";
            }
            else
            {
                WaterConsumptionsList = _context.WaterConsumptions.ToList();
            }
        }
    }
}
