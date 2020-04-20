using Nop.Core.Domain.Media;
using Nop.Services.Caching;

namespace Nop.Services.Media.CacheEventConsumers
{
    /// <summary>
    /// Represents a download cache event consumer
    /// </summary>
    public partial class DownloadCacheEventConsumer : CacheEventConsumer<Download>
    {
    }
}
