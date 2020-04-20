using Nop.Core.Domain.Tasks;
using Nop.Services.Caching;

namespace Nop.Services.Tasks.CacheEventConsumers
{
    /// <summary>
    /// Represents a schedule task cache event consumer
    /// </summary>
    public partial class ScheduleTaskCacheEventConsumer : CacheEventConsumer<ScheduleTask>
    {
    }
}
