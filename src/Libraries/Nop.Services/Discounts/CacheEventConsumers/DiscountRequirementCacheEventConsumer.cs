using Nop.Core.Domain.Discounts;
using Nop.Services.Caching;

namespace Nop.Services.Discounts.CacheEventConsumers
{
    /// <summary>
    /// Represents a discount requirement cache event consumer
    /// </summary>
    public partial class DiscountRequirementCacheEventConsumer : CacheEventConsumer<DiscountRequirement>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(DiscountRequirement entity)
        {
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopDiscountDefaults.DiscountRequirementModelCacheKey, entity.DiscountId);
            Remove(cacheKey);
        }
    }
}
