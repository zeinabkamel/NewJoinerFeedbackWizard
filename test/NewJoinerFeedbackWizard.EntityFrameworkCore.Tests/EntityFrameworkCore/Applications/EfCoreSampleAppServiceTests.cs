using NewJoinerFeedbackWizard.Samples;
using Xunit;

namespace NewJoinerFeedbackWizard.EntityFrameworkCore.Applications;

[Collection(NewJoinerFeedbackWizardTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NewJoinerFeedbackWizardEntityFrameworkCoreTestModule>
{

}
