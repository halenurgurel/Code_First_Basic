using Code_First_Basic.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_First_Basic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HALEONUR; Database=PatikaCodeFirstDb1; Trusted_Connection=true;TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
