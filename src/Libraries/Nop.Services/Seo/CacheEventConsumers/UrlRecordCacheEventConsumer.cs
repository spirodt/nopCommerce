using Nop.Core.Domain.Seo;
using Nop.Services.Caching;

namespace Nop.Services.Seo.CacheEventConsumers
{
    /// <summary>
    /// Represents an URL record cache event consumer
    /// </summary>
    public partial class UrlRecordCacheEventConsumer : CacheEventConsumer<UrlRecord>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(UrlRecord entity)
        {
            Remove(NopSeoDefaults.UrlRecordAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopSeoDefaults.UrlRecordActiveByIdNameLanguageCacheKey
                , entity.EntityId, entity.EntityName, entity.LanguageId);
            Remove(cacheKey);

            RemoveByPrefix(NopSeoDefaults.UrlRecordByIdsPrefixCacheKey);

            cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopSeoDefaults.UrlRecordBySlugCacheKey, entity.Slug);
            Remove(cacheKey);
        }
    }
}
