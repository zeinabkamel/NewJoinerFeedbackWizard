using Volo.Abp.Modularity;

namespace NewJoinerFeedbackWizard;

/* Inherit from this class for your domain layer tests. */
public abstract class NewJoinerFeedbackWizardDomainTestBase<TStartupModule> : NewJoinerFeedbackWizardTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
