using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashKeysCommand : CacheCommand<HashKeysResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        protected override async Task<HashKeysResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashKeysAsync(server, this).ConfigureAwait(false);
        }
    }
}
