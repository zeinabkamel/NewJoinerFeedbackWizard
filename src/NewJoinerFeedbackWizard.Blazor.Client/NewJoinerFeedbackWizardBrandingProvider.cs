using Microsoft.Extensions.Localization;
using NewJoinerFeedbackWizard.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NewJoinerFeedbackWizard.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class NewJoinerFeedbackWizardBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NewJoinerFeedbackWizardResource> _localizer;

    public NewJoinerFeedbackWizardBrandingProvider(IStringLocalizer<NewJoinerFeedbackWizardResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
