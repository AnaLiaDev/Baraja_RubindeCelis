using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Baraja_RubindeCelis.Models;

namespace Baraja_RubindeCelis.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Baraja_RubindeCelis.Models.Baraja> Baraja { get; set; }
    }
}
