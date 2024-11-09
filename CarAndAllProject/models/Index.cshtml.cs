using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarAndAllProject.Data;

namespace CarAndAllProject.models
{
    public class IndexModel : PageModel
    {
        private readonly CarAndAllProject.Data.CarAndAllProjectContext _context;

        public IndexModel(CarAndAllProject.Data.CarAndAllProjectContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
