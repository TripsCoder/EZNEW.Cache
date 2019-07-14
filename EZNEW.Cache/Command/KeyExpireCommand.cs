using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyExpireCommand : CacheCommand<KeyExpireResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// expire
        /// </summary>
        public DateTime? Expire
        {
            get; set;
        }

        protected override async Task<KeyExpireResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyExpireAsync(server, this).ConfigureAwait(false);
        }
    }
}
