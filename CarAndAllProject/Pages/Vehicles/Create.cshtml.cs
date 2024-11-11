using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarAndAllProject.Data;
using CarAndAllProject.models;
using Microsoft.AspNetCore.Authorization;

namespace CarAndAllProject.Pages.Vehicles
{
    [Authorize(Roles = "Administrator,Huurpark")]
    public class CreateModel : PageModel
    {
        private readonly CarAndAllProject.Data.CarAndAllProjectContext _context;

        public CreateModel(CarAndAllProject.Data.CarAndAllProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            VehicleTypes = new List<SelectListItem>
            {
                new SelectListItem { Value = "Auto", Text = "Auto" },
                new SelectListItem { Value = "Camper", Text = "Camper" },
                new SelectListItem { Value = "Caravan", Text = "Caravan" }
            };
            return Page();
        }

        [BindProperty]
        public Vehicle Vehicle { get; set; } = default!;

        [BindProperty]
        public List<SelectListItem> VehicleTypes { get; set; } = new List<SelectListItem>();

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vehicle.Add(Vehicle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
