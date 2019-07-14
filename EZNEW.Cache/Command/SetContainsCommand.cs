using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetContainsCommand : CacheCommand<SetContainsResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
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

        protected override async Task<SetContainsResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetContainsAsync(server, this).ConfigureAwait(false);
        }
    }
}
