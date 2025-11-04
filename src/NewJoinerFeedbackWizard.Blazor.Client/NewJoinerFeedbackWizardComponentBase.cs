using NewJoinerFeedbackWizard.Localization;
using Volo.Abp.AspNetCore.Components;

namespace NewJoinerFeedbackWizard.Blazor.Client;

public abstract class NewJoinerFeedbackWizardComponentBase : AbpComponentBase
{
    protected NewJoinerFeedbackWizardComponentBase()
    {
        LocalizationResource = typeof(NewJoinerFeedbackWizardResource);
    }
}
