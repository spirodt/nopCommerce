using Nop.Core.Domain.Localization;
using Nop.Services.Caching;

namespace Nop.Services.Localization.CacheEventConsumers
{
    /// <summary>
    /// Represents a language cache event consumer
    /// </summary>
    public partial class LanguageCacheEventConsumer : CacheEventConsumer<Language>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(Language entity)
        {
            Remove(_cacheKeyService.PrepareKeyForDefaultCache(NopLocalizationDefaults.LocaleStringResourcesAllPublicCacheKey, entity));
            Remove(_cacheKeyService.PrepareKeyForDefaultCache(NopLocalizationDefaults.LocaleStringResourcesAllAdminCacheKey, entity));
            Remove(_cacheKeyService.PrepareKeyForDefaultCache(NopLocalizationDefaults.LocaleStringResourcesAllCacheKey, entity));

            var prefix = _cacheKeyService.PrepareKeyPrefix(NopLocalizationDefaults.LocaleStringResourcesByResourceNamePrefixCacheKey, entity);
            RemoveByPrefix(prefix);

            RemoveByPrefix(NopLocalizationDefaults.LanguagesAllPrefixCacheKey);
        }
    }
}