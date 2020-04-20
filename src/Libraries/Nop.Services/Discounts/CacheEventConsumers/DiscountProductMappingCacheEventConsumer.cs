using Nop.Core.Domain.Discounts;
using Nop.Services.Caching;

namespace Nop.Services.Discounts.CacheEventConsumers
{
    /// <summary>
    /// Represents a discount-product mapping cache event consumer
    /// </summary>
    public partial class DiscountProductMappingCacheEventConsumer : CacheEventConsumer<DiscountManufacturerMapping>
    {
    }
}