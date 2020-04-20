using Nop.Core.Domain.Vendors;
using Nop.Services.Caching;

namespace Nop.Services.Vendors.CacheEventConsumers
{
    /// <summary>
    /// Represents a vendor note cache event consumer
    /// </summary>
    public partial class VendorNoteCacheEventConsumer : CacheEventConsumer<VendorNote>
    {
    }
}
