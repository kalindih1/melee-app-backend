using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Melee_percent_app.Models
{
    public class MeleeDbContext : DbContext
    {
        public DbSet<MeleeCharacters> MeleeCharacters { get; set; }

        public DbSet<Stages> MeleeStages { get; set; }

        public DbSet<KillPercent> KillPercent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Melee%; Trusted_Connection=True;");
        }
    }
}
