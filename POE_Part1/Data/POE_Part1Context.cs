using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POE_Part1.Models;

namespace POE_Part1.Data
{
    public class POE_Part1Context : DbContext
    {
        public POE_Part1Context (DbContextOptions<POE_Part1Context> options)
            : base(options)
        {
        }

        public DbSet<POE_Part1.Models.Venue> Venue { get; set; } = default!;
        public DbSet<POE_Part1.Models.Event> Event { get; set; } = default!;
        public DbSet<POE_Part1.Models.Booking> Booking { get; set; } = default!;
    }
}
