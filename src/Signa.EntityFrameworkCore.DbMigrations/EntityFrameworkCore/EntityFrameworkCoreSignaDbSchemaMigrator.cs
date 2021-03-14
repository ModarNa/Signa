using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Signa.Data;
using Volo.Abp.DependencyInjection;

namespace Signa.EntityFrameworkCore
{
    public class EntityFrameworkCoreSignaDbSchemaMigrator
        : ISignaDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSignaDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SignaMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SignaMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}