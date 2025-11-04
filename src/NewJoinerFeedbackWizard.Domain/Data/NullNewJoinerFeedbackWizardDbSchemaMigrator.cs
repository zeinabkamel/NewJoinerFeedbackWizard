using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NewJoinerFeedbackWizard.Data;

/* This is used if database provider does't define
 * INewJoinerFeedbackWizardDbSchemaMigrator implementation.
 */
public class NullNewJoinerFeedbackWizardDbSchemaMigrator : INewJoinerFeedbackWizardDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
