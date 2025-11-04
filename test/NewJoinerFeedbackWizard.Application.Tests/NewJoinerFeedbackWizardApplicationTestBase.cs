using Volo.Abp.Modularity;

namespace NewJoinerFeedbackWizard;

public abstract class NewJoinerFeedbackWizardApplicationTestBase<TStartupModule> : NewJoinerFeedbackWizardTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
