using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SaveServerConfigCommand : CacheCommand<SaveServerConfigResponse>
    {
        /// <summary>
        /// config
        /// </summary>
        public CacheServerConfig ServerConfig
        {
            get; set;
        }

        protected override async Task<SaveServerConfigResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SaveServerConfigAsync(server, this).ConfigureAwait(false);
        }
    }
}
