using Nop.Core.Domain.Discounts;
using Nop.Services.Caching;

namespace Nop.Services.Discounts.CacheEventConsumers
{
    /// <summary>
    /// Represents a discount-category mapping cache event consumer
    /// </summary>
    public partial class DiscountCategoryMappingCacheEventConsumer : CacheEventConsumer<DiscountCategoryMapping>
    {
    }
}