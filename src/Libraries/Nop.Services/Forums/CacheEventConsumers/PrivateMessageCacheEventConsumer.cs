using Nop.Core.Domain.Forums;
using Nop.Services.Caching;

namespace Nop.Services.Forums.CacheEventConsumers
{
    /// <summary>
    /// Represents a private message cache event consumer
    /// </summary>
    public partial class PrivateMessageCacheEventConsumer : CacheEventConsumer<PrivateMessage>
    {
    }
}
