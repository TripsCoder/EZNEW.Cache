using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetAddCommand : CacheCommand<SortedSetAddResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// members
        /// </summary>
        public List<SortedSetValueItem> Members
        {
            get; set;
        }

        protected override async Task<SortedSetAddResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetAddAsync(server, this).ConfigureAwait(false);
        }
    }
}
