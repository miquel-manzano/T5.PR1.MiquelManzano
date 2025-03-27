using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.Simulations
{
    public class AddSimulationModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public AddSimulationModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Simulation NewEntry { get; set; }

        public IActionResult OnPost()
        {
            // Temporal HardCode
            //GeneratedEnergy KWhCost KWhPrice Date
            NewEntry.GeneratedEnergy = 0.00f;
            NewEntry.KWhCost = 0.00f;
            NewEntry.KWhPrice = 0.00f;
            NewEntry.Date = DateTime.Now;

            _context.Simulations.Add(NewEntry);
            _context.SaveChanges();
            return RedirectToPage("/Simulations/SimulationsTable");
        }
    }
}
