using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetRankCommand : CacheCommand<SortedSetRankResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// member
        /// </summary>
        public string Member
        {
            get; set;
        }

        /// <summary>
        /// order
        /// </summary>
        public SortedOrder Order
        {
            get; set;
        } = SortedOrder.Ascending;

        protected override async Task<SortedSetRankResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetRankAsync(server, this).ConfigureAwait(false);
        }
    }
}
