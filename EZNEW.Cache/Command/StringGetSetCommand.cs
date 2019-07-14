using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringGetSetCommand : CacheCommand<StringGetSetResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// new value
        /// </summary>
        public string NewValue
        {
            get; set;
        }

        protected override async Task<StringGetSetResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringGetSetAsync(server, this).ConfigureAwait(false);
        }
    }
}
