using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListGetByIndexCommand : CacheCommand<ListGetByIndexResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// index
        /// </summary>
        public long Index
        {
            get; set;
        }

        protected override async Task<ListGetByIndexResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListGetByIndexAsync(server, this).ConfigureAwait(false);
        }
    }
}
