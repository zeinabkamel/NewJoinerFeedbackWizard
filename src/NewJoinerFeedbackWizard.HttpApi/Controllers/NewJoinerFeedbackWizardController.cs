using NewJoinerFeedbackWizard.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NewJoinerFeedbackWizard.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NewJoinerFeedbackWizardController : AbpControllerBase
{
    protected NewJoinerFeedbackWizardController()
    {
        LocalizationResource = typeof(NewJoinerFeedbackWizardResource);
    }
}
