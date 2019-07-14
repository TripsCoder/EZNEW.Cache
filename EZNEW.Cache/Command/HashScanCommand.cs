using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashScanCommand : CacheCommand<HashScanResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// pattern
        /// </summary>
        public string Pattern
        {
            get; set;
        }

        /// <summary>
        /// page size
        /// </summary>
        public int PageSize
        {
            get; set;
        }

        protected override async Task<HashScanResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashScanAsync(server, this).ConfigureAwait(false);
        }
    }
}
