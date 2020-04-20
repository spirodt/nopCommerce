using Nop.Core.Domain.Polls;
using Nop.Services.Caching;

namespace Nop.Services.Polls.CacheEventConsumers
{
    /// <summary>
    /// Represents a poll answer cache event consumer
    /// </summary>
    public partial class PollAnswerCacheEventConsumer : CacheEventConsumer<PollAnswer>
    {
    }
}