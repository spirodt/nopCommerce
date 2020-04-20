using Nop.Core.Domain.Catalog;
using Nop.Services.Caching;

namespace Nop.Services.Catalog.CacheEventConsumers
{
    /// <summary>
    /// Represents a product attribute combination cache event consumer
    /// </summary>
    public partial class ProductAttributeCombinationCacheEventConsumer : CacheEventConsumer<ProductAttributeCombination>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ProductAttributeCombination entity)
        {
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopCatalogDefaults.ProductAttributeMappingsAllCacheKey, entity.ProductId);
            Remove(cacheKey);

            cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopCatalogDefaults.ProductAttributeCombinationsAllCacheKey, entity.ProductId);
            Remove(cacheKey);
        }
    }
}
