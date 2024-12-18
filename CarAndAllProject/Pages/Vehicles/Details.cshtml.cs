﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarAndAllProject.Data;
using CarAndAllProject.models;
using Microsoft.AspNetCore.Authorization;

namespace CarAndAllProject.Pages.Vehicles
{
    [Authorize(Roles = "Administrator,Huurpark")]
    public class DetailsModel : PageModel
    {
        private readonly CarAndAllProject.Data.CarAndAllProjectContext _context;

        public DetailsModel(CarAndAllProject.Data.CarAndAllProjectContext context)
        {
            _context = context;
        }

        public Vehicle Vehicle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            else
            {
                Vehicle = vehicle;
            }
            return Page();
        }
    }
}
