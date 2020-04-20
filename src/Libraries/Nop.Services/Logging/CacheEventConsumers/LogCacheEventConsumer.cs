using Nop.Core.Domain.Logging;
using Nop.Services.Caching;

namespace Nop.Services.Logging.CacheEventConsumers
{
    /// <summary>
    /// Represents a log cache event consumer
    /// </summary>
    public partial class LogCacheEventConsumer : CacheEventConsumer<Log>
    {
    }
}
