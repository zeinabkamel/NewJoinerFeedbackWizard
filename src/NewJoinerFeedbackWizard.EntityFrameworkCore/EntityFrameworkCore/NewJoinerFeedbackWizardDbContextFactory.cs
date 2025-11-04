using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NewJoinerFeedbackWizard.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NewJoinerFeedbackWizardDbContextFactory : IDesignTimeDbContextFactory<NewJoinerFeedbackWizardDbContext>
{
    public NewJoinerFeedbackWizardDbContext CreateDbContext(string[] args)
    {
        NewJoinerFeedbackWizardEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NewJoinerFeedbackWizardDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new NewJoinerFeedbackWizardDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NewJoinerFeedbackWizard.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
