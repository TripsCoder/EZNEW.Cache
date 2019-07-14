using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyDeleteCommand : CacheCommand<KeyDeleteResponse>
    {
        /// <summary>
        /// keys
        /// </summary>
        public List<string> Keys
        {
            get; set;
        }

        protected override async Task<KeyDeleteResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyDeleteAsync(server, this).ConfigureAwait(false);
        }
    }
}
