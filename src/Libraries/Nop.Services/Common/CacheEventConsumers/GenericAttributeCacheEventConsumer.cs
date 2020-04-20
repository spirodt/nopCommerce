using Nop.Core.Domain.Common;
using Nop.Services.Caching;

namespace Nop.Services.Common.CacheEventConsumers
{
    /// <summary>
    /// Represents a generic attribute cache event consumer
    /// </summary>
    public partial class GenericAttributeCacheEventConsumer : CacheEventConsumer<GenericAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(GenericAttribute entity)
        {
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopCommonDefaults.GenericAttributeCacheKey, entity.EntityId, entity.KeyGroup);
            Remove(cacheKey);
        }
    }
}
