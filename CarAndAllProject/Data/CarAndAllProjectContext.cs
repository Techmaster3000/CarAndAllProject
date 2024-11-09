using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarAndAllProject.models;

namespace CarAndAllProject.Data
{
    public class CarAndAllProjectContext : DbContext
    {
        public CarAndAllProjectContext (DbContextOptions<CarAndAllProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CarAndAllProject.models.User> User { get; set; } = default!;
    }
}
