using DeployApiAndSqlInAzure;
using Microsoft.EntityFrameworkCore;
using TestDeployApiAndSqlInAzure.Models;

namespace TestDeployApiAndSqlInAzure.DbContexts;

public class WeatherDbContext(DbContextOptions<WeatherDbContext> options) : DbContext(options)
{
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(ReferenceAssembly.Assembly);
}
