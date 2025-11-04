using NewJoinerFeedbackWizard.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NewJoinerFeedbackWizard.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NewJoinerFeedbackWizardEntityFrameworkCoreModule),
    typeof(NewJoinerFeedbackWizardApplicationContractsModule)
    )]
public class NewJoinerFeedbackWizardDbMigratorModule : AbpModule
{
}
