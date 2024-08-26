using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABPOnlineStore.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ABPOnlineStoreDbContextFactory : IDesignTimeDbContextFactory<ABPOnlineStoreDbContext>
{
    public ABPOnlineStoreDbContext CreateDbContext(string[] args)
    {
        ABPOnlineStoreEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ABPOnlineStoreDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ABPOnlineStoreDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ABPOnlineStore.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
