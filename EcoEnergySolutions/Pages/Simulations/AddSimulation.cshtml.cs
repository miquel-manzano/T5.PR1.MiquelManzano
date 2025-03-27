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
            NewEntry.GeneratedEnergy = EnergyGenerated(NewEntry.WaterFlow);
            NewEntry.KWhCost = EnergyPrice(NewEntry.SunHours);
            NewEntry.KWhPrice = EnergyPrice(NewEntry.WindSpeed);
            NewEntry.Date = DateTime.Now;

            _context.Simulations.Add(NewEntry);
            _context.SaveChanges();
            return RedirectToPage("/Simulations/SimulationsTable");
        }

        private Double EnergyGenerated(double value)
        {
            return (value * 15) / 2;
        }
        private Double EnergyPrice(double value)
        {
            return value * 10;
        }
    }
}
