using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Signa.EntityFrameworkCore
{
    [DependsOn(
        typeof(SignaEntityFrameworkCoreModule)
        )]
    public class SignaEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SignaMigrationsDbContext>();
        }
    }
}
