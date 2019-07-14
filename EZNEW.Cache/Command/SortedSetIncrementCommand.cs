using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetIncrementCommand : CacheCommand<SortedSetIncrementResponse>
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
        /// score value
        /// </summary>
        public double IncrementScore
        {
            get; set;
        }

        protected override async Task<SortedSetIncrementResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetIncrementAsync(server, this).ConfigureAwait(false);
        }
    }
}
