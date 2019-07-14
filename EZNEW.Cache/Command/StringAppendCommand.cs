using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringAppendCommand : CacheCommand<StringAppendResponse>
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

        protected override async Task<StringAppendResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringAppendAsync(server, this).ConfigureAwait(false);
        }
    }
}
