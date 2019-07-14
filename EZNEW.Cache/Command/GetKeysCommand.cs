using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class GetKeysCommand : CacheCommand<GetKeysResponse>
    {
        /// <summary>
        /// key query
        /// </summary>
        public KeyQuery Query
        {
            get; set;
        }

        protected override async Task<GetKeysResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.GetKeysAsync(server, this).ConfigureAwait(false);
        }
    }
}
