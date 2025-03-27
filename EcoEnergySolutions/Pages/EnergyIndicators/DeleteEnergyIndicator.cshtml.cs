using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class DeleteEnergyIndicatorModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteEnergyIndicatorModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EnergyIndicator EnergyIndicator { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EnergyIndicator = await _context.EnergyIndicators.FirstOrDefaultAsync(m => m.Id == id);

            if (EnergyIndicator == null)
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

            EnergyIndicator = await _context.EnergyIndicators.FindAsync(id);

            if (EnergyIndicator != null)
            {
                _context.EnergyIndicators.Remove(EnergyIndicator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/EnergyIndicators/EnergyIndicatorsTable");
        }
    }
}
