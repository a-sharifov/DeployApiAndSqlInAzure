using Microsoft.EntityFrameworkCore;

namespace DeployApiAndSqlInAzure.DbContexts.Extensions;

public static class ApplicationBuilderExtension
{
    public static IApplicationBuilder MigrateDbContext<TDbContext>(this IApplicationBuilder builder)
      where TDbContext : DbContext
    {
        using var scope = builder.ApplicationServices.CreateScope();
        using var dbContext = scope.ServiceProvider.GetRequiredService<TDbContext>();

        dbContext.Database.Migrate();
        return builder;
    }
}
