using ChargeShare.AdresService.DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace ChargeShare.AdresService.DAL.Contexts;

public class AdresContext : DbContext
{
    private string connectionString = "TempDB";

    public DbSet<ChargeStationModel> Adresses { get; set; }


    public AdresContext()
    {

    }

    public AdresContext(DbContextOptions<AdresContext> context) : base(context)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdresConfiguration());
    }
}