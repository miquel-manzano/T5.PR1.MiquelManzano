using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace EcoEnergySolutions.Pages.Simulations
{
    public class SimulationsTableModel : PageModel
    {
        public List<Simulation> SimulationsList { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            using var dbContext = new ApplicationDbContext();
            SimulationsList = new List<Simulation>();

            if (dbContext.Simulations.IsNullOrEmpty())
            {
                Message = "No data found...";
            }
            else
            {
                SimulationsList = dbContext.Simulations.ToList();
            }
        }
    }
}
