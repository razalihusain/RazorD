using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorD.Models;

namespace RazorD.Data
{
    public class RazorDContext : DbContext
    {
        public RazorDContext (DbContextOptions<RazorDContext> options)
            : base(options)
        {
        }

        public DbSet<RazorD.Models.Movie> Movie { get; set; }
    }
}
