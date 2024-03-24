using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDeployApiAndSqlInAzure.Models;

namespace DeployApiAndSqlInAzure.DbContexts.Configurations;

public sealed class WeatherForecastConfiguration : IEntityTypeConfiguration<WeatherForecast>
{
    public void Configure(EntityTypeBuilder<WeatherForecast> builder)
    {
        builder.HasKey(w => w.Id);

        builder.Property(w => w.Summary)
            .HasMaxLength(100);
    }
}
