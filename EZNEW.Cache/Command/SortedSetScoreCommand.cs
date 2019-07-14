using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetScoreCommand : CacheCommand<SortedSetScoreResponse>
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

        protected override async Task<SortedSetScoreResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetScoreAsync(server, this).ConfigureAwait(false);
        }
    }
}
