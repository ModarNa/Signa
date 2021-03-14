using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Signa.Data
{
    /* This is used if database provider does't define
     * ISignaDbSchemaMigrator implementation.
     */
    public class NullSignaDbSchemaMigrator : ISignaDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}