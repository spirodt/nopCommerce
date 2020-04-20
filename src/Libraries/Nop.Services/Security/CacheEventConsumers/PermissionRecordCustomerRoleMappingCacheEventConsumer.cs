using Nop.Core.Domain.Security;
using Nop.Services.Caching;

namespace Nop.Services.Security.CacheEventConsumers
{
    /// <summary>
    /// Represents a permission record-customer role mapping cache event consumer
    /// </summary>
    public partial class PermissionRecordCustomerRoleMappingCacheEventConsumer : CacheEventConsumer<PermissionRecordCustomerRoleMapping>
    {
    }
}