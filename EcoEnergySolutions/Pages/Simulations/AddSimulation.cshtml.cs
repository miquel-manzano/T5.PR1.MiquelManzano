using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcoEnergySolutions.Pages.Simulations
{
    public class AddSimulationModel : PageModel
    {
        [BindProperty]
        public Simulation NewEntry { get; set; }

        public IActionResult OnPost()
        {
            using var dbContext = new ApplicationDbContext();

            // Temporal HardCode
            //GeneratedEnergy KWhCost KWhPrice Date
            NewEntry.GeneratedEnergy = 0.00f;
            NewEntry.KWhCost = 0.00f;
            NewEntry.KWhPrice = 0.00f;
            NewEntry.Date = DateTime.Now;

            dbContext.Simulations.Add(NewEntry);
            dbContext.SaveChanges();
            return RedirectToPage("/Simulations/SimulationsTable");
        }
    }
}
