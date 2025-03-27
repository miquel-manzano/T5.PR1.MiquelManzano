using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace EcoEnergySolutions.Pages.Simulations
{
    public class SimulationsTableModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public SimulationsTableModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Simulation> SimulationsList { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            SimulationsList = new List<Simulation>();

            if (_context.Simulations.IsNullOrEmpty())
            {
                Message = "No data found...";
            }
            else
            {
                SimulationsList = _context.Simulations.ToList();
            }
        }
    }
}
