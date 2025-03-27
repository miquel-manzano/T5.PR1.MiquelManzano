using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Pages.Simulations
{
    public class DeleteSimulationsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteSimulationsModel(ApplicationDbContext context)
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

            Simulation = await _context.Simulations.FirstOrDefaultAsync(m => m.Id == id);

            if (Simulation == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Simulation = await _context.Simulations.FindAsync(id);

            if (Simulation != null)
            {
                _context.Simulations.Remove(Simulation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Simulations/SimulationsTable");
        }
    }
}
