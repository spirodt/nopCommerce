using Nop.Core.Domain.Logging;
using Nop.Services.Caching;

namespace Nop.Services.Logging.CacheEventConsumers
{
    /// <summary>
    /// Represents a activity log type cache event consumer
    /// </summary>
    public partial class ActivityLogTypeCacheEventConsumer : CacheEventConsumer<ActivityLogType>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ActivityLogType entity)
        {
            Remove(NopLoggingDefaults.ActivityTypeAllCacheKey);
        }
    }
}
