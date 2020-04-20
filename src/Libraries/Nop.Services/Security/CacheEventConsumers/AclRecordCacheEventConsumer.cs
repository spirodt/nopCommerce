using Nop.Core.Domain.Security;
using Nop.Services.Caching;

namespace Nop.Services.Security.CacheEventConsumers
{
    /// <summary>
    /// Represents a ACL record cache event consumer
    /// </summary>
    public partial class AclRecordCacheEventConsumer : CacheEventConsumer<AclRecord>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(AclRecord entity)
        {
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopSecurityDefaults.AclRecordByEntityIdNameCacheKey, entity.EntityId, entity.EntityName);
            Remove(cacheKey);
        }
    }
}
