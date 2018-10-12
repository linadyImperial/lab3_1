using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab1A.Models;

namespace lab1A.Models
{
    public class lab1AContext : DbContext
    {
        public lab1AContext (DbContextOptions<lab1AContext> options)
            : base(options)
        {
        }

        public DbSet<lab1A.Models.Car> Car { get; set; }

        public DbSet<lab1A.Models.Member> Member { get; set; }

        public DbSet<lab1A.Models.Dealership> Dealership { get; set; }
    }
}
