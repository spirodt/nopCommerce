using Nop.Core.Domain.Messages;
using Nop.Services.Caching;

namespace Nop.Services.Messages.CacheEventConsumers
{
    /// <summary>
    /// Represents a campaign cache event consumer
    /// </summary>
    public partial class CampaignCacheEventConsumer : CacheEventConsumer<Campaign>
    {
    }
}
