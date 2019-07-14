using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashExistsCommand : CacheCommand<HashExistsResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// field
        /// </summary>
        public string HashField
        {
            get; set;
        }

        protected override async Task<HashExistsResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashExistsAsync(server, this).ConfigureAwait(false);
        }
    }
}
