using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Pages.Simulations
{
    public class EditSimulationsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditSimulationsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Simulation Simulation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Simulation = await _context.Simulations.FindAsync(id);

            if (Simulation == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Simulation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SimulationExists(Simulation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Simulations/SimulationsTable");
        }

        private bool SimulationExists(int id)
        {
            return _context.Simulations.Any(e => e.Id == id);
        }
    }
}
