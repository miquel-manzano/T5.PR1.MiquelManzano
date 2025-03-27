using EcoEnergySolutions.Data;
using EcoEnergySolutions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Pages.WaterConsumptions
{
    public class DeleteWaterConsumptionModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteWaterConsumptionModel(ApplicationDbContext context)
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

            WaterConsumption = await _context.WaterConsumptions.FirstOrDefaultAsync(m => m.Id == id);

            if (WaterConsumption == null)
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

            WaterConsumption = await _context.WaterConsumptions.FindAsync(id);

            if (WaterConsumption != null)
            {
                _context.WaterConsumptions.Remove(WaterConsumption);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/WaterConsumptions/WaterConsumptionsTable");
        }
    }
}
