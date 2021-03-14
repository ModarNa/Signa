using Signa.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Signa.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SignaEntityFrameworkCoreDbMigrationsModule),
        typeof(SignaApplicationContractsModule)
        )]
    public class SignaDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
