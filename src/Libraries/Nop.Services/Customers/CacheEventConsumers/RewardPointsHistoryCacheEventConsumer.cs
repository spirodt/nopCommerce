using Nop.Core.Domain.Customers;
using Nop.Services.Caching;

namespace Nop.Services.Customers.CacheEventConsumers
{
    /// <summary>
    /// Represents a reward point history cache event consumer
    /// </summary>
    public partial class RewardPointsHistoryCacheEventConsumer : CacheEventConsumer<RewardPointsHistory>
    {
    }
}
