using Lunchbox.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox
{
    public class LunchboxDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public LunchboxDbContext(DbContextOptions<LunchboxDbContext> options) : base(options) { 
        
        }
        

    }
}
