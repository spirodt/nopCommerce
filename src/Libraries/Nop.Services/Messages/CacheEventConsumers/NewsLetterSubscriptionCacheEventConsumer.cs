using Nop.Core.Domain.Messages;
using Nop.Services.Caching;

namespace Nop.Services.Messages.CacheEventConsumers
{
    /// <summary>
    /// Represents news letter subscription cache event consumer
    /// </summary>
    public partial class NewsLetterSubscriptionCacheEventConsumer : CacheEventConsumer<NewsLetterSubscription>
    {    
    }
}
