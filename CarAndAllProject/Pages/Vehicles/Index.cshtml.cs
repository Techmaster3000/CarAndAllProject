using System;
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
    public class IndexModel : PageModel
    {
        private readonly CarAndAllProject.Data.CarAndAllProjectContext _context;

        public IndexModel(CarAndAllProject.Data.CarAndAllProjectContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
