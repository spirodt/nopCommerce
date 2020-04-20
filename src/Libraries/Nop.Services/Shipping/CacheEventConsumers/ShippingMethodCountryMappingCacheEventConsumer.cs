using Nop.Core.Domain.Shipping;
using Nop.Services.Caching;

namespace Nop.Services.Shipping.CacheEventConsumers
{
    /// <summary>
    /// Represents a shipping method-country mapping cache event consumer
    /// </summary>
    public partial class ShippingMethodCountryMappingCacheEventConsumer : CacheEventConsumer<ShippingMethodCountryMapping>
    {
    }
}