using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class EnergyIndicatorsTableModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EnergyIndicatorsTableModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EnergyIndicator> EnergyIndicatorsList { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            EnergyIndicatorsList = new List<EnergyIndicator>();

            if (_context.EnergyIndicators.IsNullOrEmpty())
            {
                Message = "No data found...";
            }
            else
            {
                EnergyIndicatorsList = _context.EnergyIndicators.ToList();
            }            
        }
    }
}
