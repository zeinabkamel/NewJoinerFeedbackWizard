using Volo.Abp.Modularity;

namespace NewJoinerFeedbackWizard;

[DependsOn(
    typeof(NewJoinerFeedbackWizardDomainModule),
    typeof(NewJoinerFeedbackWizardTestBaseModule)
)]
public class NewJoinerFeedbackWizardDomainTestModule : AbpModule
{

}
