using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewJoinerFeedbackWizard.Data;
using Volo.Abp.DependencyInjection;

namespace NewJoinerFeedbackWizard.EntityFrameworkCore;

public class EntityFrameworkCoreNewJoinerFeedbackWizardDbSchemaMigrator
    : INewJoinerFeedbackWizardDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNewJoinerFeedbackWizardDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the NewJoinerFeedbackWizardDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NewJoinerFeedbackWizardDbContext>()
            .Database
            .MigrateAsync();
    }
}
