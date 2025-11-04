using System.Threading.Tasks;

namespace NewJoinerFeedbackWizard.Data;

public interface INewJoinerFeedbackWizardDbSchemaMigrator
{
    Task MigrateAsync();
}
