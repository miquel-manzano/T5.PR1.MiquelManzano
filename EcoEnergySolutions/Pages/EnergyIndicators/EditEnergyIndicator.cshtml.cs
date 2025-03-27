using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Pages.EnergyIndicators
{
    public class EditEnergyIndicatorModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditEnergyIndicatorModel(ApplicationDbContext context)
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

            EnergyIndicator = await _context.EnergyIndicators.FindAsync(id);

            if (EnergyIndicator == null)
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

            _context.Attach(EnergyIndicator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnergyIndicatorExists(EnergyIndicator.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/EnergyIndicators/EnergyIndicatorsTable");
        }

        private bool EnergyIndicatorExists(int id)
        {
            return _context.EnergyIndicators.Any(e => e.Id == id);
        }
    }
}
