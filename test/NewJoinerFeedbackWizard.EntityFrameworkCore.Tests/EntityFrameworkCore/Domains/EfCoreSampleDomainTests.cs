using NewJoinerFeedbackWizard.Samples;
using Xunit;

namespace NewJoinerFeedbackWizard.EntityFrameworkCore.Domains;

[Collection(NewJoinerFeedbackWizardTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NewJoinerFeedbackWizardEntityFrameworkCoreTestModule>
{

}
