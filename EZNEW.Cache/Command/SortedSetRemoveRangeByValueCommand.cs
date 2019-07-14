using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetRemoveRangeByValueCommand : CacheCommand<SortedSetRemoveRangeByValueResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// min value
        /// </summary>
        public string MinValue
        {
            get; set;
        }

        /// <summary>
        /// max value
        /// </summary>
        public string MaxValue
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

        protected override async Task<SortedSetRemoveRangeByValueResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetRemoveRangeByValueAsync(server, this).ConfigureAwait(false);
        }
    }
}
