using System.Threading.Tasks;

namespace ABPOnlineStore.Data;

public interface IABPOnlineStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
