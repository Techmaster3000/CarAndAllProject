using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CarAndAllProject.models;

namespace CarAndAllProject.Data
{
    public class CarAndAllProjectContext : IdentityDbContext<IdentityUser>
    {
        public CarAndAllProjectContext (DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarAndAllProject.models.User> User { get; set; } = default!;
        public DbSet<CarAndAllProject.models.Vehicle> Vehicle { get; set; } = default!;
    }
}
