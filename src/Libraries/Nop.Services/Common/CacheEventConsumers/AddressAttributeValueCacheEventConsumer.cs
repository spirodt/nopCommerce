using Nop.Core.Domain.Common;
using Nop.Services.Caching;

namespace Nop.Services.Common.CacheEventConsumers
{
    /// <summary>
    /// Represents a address attribute value cache event consumer
    /// </summary>
    public partial class AddressAttributeValueCacheEventConsumer : CacheEventConsumer<AddressAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(AddressAttributeValue entity)
        {
            Remove(NopCommonDefaults.AddressAttributesAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopCommonDefaults.AddressAttributeValuesAllCacheKey, entity.AddressAttributeId);
            Remove(cacheKey);
        }
    }
}
