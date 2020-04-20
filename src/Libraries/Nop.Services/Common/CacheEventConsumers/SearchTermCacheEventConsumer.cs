using Nop.Core.Domain.Common;
using Nop.Services.Caching;

namespace Nop.Services.Common.CacheEventConsumers
{
    /// <summary>
    /// Represents a search term cache event consumer
    /// </summary>
    public partial class SearchTermCacheEventConsumer : CacheEventConsumer<SearchTerm>
    {
    }
}
