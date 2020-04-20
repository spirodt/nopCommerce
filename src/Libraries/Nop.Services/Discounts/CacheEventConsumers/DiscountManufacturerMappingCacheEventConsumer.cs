using Nop.Core.Domain.Discounts;
using Nop.Services.Caching;

namespace Nop.Services.Discounts.CacheEventConsumers
{
    /// <summary>
    /// Represents a discount-manufacturer mapping cache event consumer
    /// </summary>
    public partial class DiscountManufacturerMappingCacheEventConsumer : CacheEventConsumer<DiscountManufacturerMapping>
    {
    }
}