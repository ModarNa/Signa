using System.Threading.Tasks;

namespace Signa.Data
{
    public interface ISignaDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
