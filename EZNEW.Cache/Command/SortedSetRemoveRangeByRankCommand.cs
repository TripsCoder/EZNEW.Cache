using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetRemoveRangeByRankCommand : CacheCommand<SortedSetRemoveRangeByRankResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// start rank
        /// </summary>
        public long Start
        {
            get; set;
        }

        /// <summary>
        /// stop rank
        /// </summary>
        public long Stop
        {
            get; set;
        }

        /// <summary>
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;

        protected override async Task<SortedSetRemoveRangeByRankResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetRemoveRangeByRankAsync(server, this).ConfigureAwait(false);
        }
    }
}
