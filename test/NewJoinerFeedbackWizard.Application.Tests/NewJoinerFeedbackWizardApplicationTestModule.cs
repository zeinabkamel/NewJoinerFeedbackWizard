using Volo.Abp.Modularity;

namespace NewJoinerFeedbackWizard;

[DependsOn(
    typeof(NewJoinerFeedbackWizardApplicationModule),
    typeof(NewJoinerFeedbackWizardDomainTestModule)
)]
public class NewJoinerFeedbackWizardApplicationTestModule : AbpModule
{

}
