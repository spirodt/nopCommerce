using Nop.Core.Domain.Polls;
using Nop.Services.Caching;

namespace Nop.Services.Polls.CacheEventConsumers
{
    /// <summary>
    /// Represents a poll voting record cache event consumer
    /// </summary>
    public partial class PollVotingRecordCacheEventConsumer : CacheEventConsumer<PollVotingRecord>
    {
    }
}