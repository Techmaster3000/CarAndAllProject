using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarAndAllProject.Data;
using CarAndAllProject.models;

namespace CarAndAllProject.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CarAndAllProjectContext _context;

        public IndexModel(CarAndAllProjectContext context)
        {
            _context = context;
        }

        public IList<User> User { get; set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
