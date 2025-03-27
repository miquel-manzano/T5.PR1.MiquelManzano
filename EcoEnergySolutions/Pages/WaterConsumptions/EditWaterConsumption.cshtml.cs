using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Pages.WaterConsumptions
{
    public class EditWaterConsumptionModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditWaterConsumptionModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WaterConsumption WaterConsumption { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WaterConsumption = await _context.WaterConsumptions.FindAsync(id);

            if (WaterConsumption == null)
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

            _context.Attach(WaterConsumption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WaterConsumptionExists(WaterConsumption.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/WaterConsumptions/WaterConsumptionsTable");
        }

        private bool WaterConsumptionExists(int id)
        {
            return _context.WaterConsumptions.Any(e => e.Id == id);
        }
    }
}