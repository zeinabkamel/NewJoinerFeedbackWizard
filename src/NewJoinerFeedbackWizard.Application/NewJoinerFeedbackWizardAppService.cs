using System;
using System.Collections.Generic;
using System.Text;
using NewJoinerFeedbackWizard.Localization;
using Volo.Abp.Application.Services;

namespace NewJoinerFeedbackWizard;

/* Inherit your application services from this class.
 */
public abstract class NewJoinerFeedbackWizardAppService : ApplicationService
{
    protected NewJoinerFeedbackWizardAppService()
    {
        LocalizationResource = typeof(NewJoinerFeedbackWizardResource);
    }
}
