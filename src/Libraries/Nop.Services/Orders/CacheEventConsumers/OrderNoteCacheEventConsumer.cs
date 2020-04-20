using Nop.Core.Domain.Orders;
using Nop.Services.Caching;

namespace Nop.Services.Orders.CacheEventConsumers
{
    /// <summary>
    /// Represents an order note cache event consumer
    /// </summary>
    public partial class OrderNoteCacheEventConsumer : CacheEventConsumer<OrderNote>
    {
    }
}
