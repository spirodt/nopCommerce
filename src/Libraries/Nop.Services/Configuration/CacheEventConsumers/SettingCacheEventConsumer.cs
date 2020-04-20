using Nop.Core.Domain.Configuration;
using Nop.Services.Caching;

namespace Nop.Services.Configuration.CacheEventConsumers
{
    /// <summary>
    /// Represents a setting cache event consumer
    /// </summary>
    public partial class SettingCacheEventConsumer : CacheEventConsumer<Setting>
    {
    }
}