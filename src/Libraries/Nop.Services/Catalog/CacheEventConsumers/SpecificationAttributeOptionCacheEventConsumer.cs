using Nop.Core.Domain.Catalog;
using Nop.Services.Caching;

namespace Nop.Services.Catalog.CacheEventConsumers
{
    /// <summary>
    /// Represents a specification attribute option cache event consumer
    /// </summary>
    public partial class SpecificationAttributeOptionCacheEventConsumer : CacheEventConsumer<SpecificationAttributeOption>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(SpecificationAttributeOption entity)
        {
            Remove(NopCatalogDefaults.SpecAttributesWithOptionsCacheKey);
            Remove(_cacheKeyService.PrepareKeyForDefaultCache(NopCatalogDefaults.SpecAttributesOptionsCacheKey, entity.SpecificationAttributeId));
        }
    }
}
