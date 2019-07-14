using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListSetByIndexCommand : CacheCommand<ListSetByIndexResponse>
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

        /// <summary>
        /// value
        /// </summary>
        public string Value
        {
            get; set;
        }

        protected override async Task<ListSetByIndexResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListSetByIndexAsync(server, this).ConfigureAwait(false);
        }
    }
}
