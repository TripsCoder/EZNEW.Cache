using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashSetCommand : CacheCommand<HashSetResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// hash values
        /// </summary>
        public Dictionary<string, string> HashValues
        {
            get; set;
        }

        protected override async Task<HashSetResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashSetAsync(server, this).ConfigureAwait(false);
        }
    }
}
