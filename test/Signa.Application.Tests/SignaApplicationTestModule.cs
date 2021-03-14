using Volo.Abp.Modularity;

namespace Signa
{
    [DependsOn(
        typeof(SignaApplicationModule),
        typeof(SignaDomainTestModule)
        )]
    public class SignaApplicationTestModule : AbpModule
    {

    }
}