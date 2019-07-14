using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashGetCommand : CacheCommand<HashGetResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// hash field
        /// </summary>
        public string HashField
        {
            get; set;
        }

        protected override async Task<HashGetResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashGetAsync(server, this).ConfigureAwait(false);
        }
    }
}
