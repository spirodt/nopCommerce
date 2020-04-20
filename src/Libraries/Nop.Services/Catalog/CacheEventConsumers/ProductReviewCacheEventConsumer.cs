using Nop.Core.Domain.Catalog;
using Nop.Services.Caching;

namespace Nop.Services.Catalog.CacheEventConsumers
{
    /// <summary>
    /// Represents a product review cache event consumer
    /// </summary>
    public partial class ProductReviewCacheEventConsumer : CacheEventConsumer<ProductReview>
    {
    }
}
