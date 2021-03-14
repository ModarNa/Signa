using Signa.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Signa
{
    [DependsOn(
        typeof(SignaEntityFrameworkCoreTestModule)
        )]
    public class SignaDomainTestModule : AbpModule
    {

    }
}