using Nop.Core.Domain.Forums;
using Nop.Services.Caching;

namespace Nop.Services.Forums.CacheEventConsumers
{
    /// <summary>
    /// Represents a forum subscription cache event consumer
    /// </summary>
    public partial class ForumSubscriptionCacheEventConsumer : CacheEventConsumer<ForumSubscription>
    {
    }
}
