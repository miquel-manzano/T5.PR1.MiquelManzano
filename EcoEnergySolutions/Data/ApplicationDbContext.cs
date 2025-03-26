using EcoEnergySolutions.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergySolutions.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<EnergyIndicator> EnergyIndicators { get; set; }
        public DbSet<WaterConsumption> WaterConsumptions { get; set; }
        public DbSet<Simulation> Simulations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
