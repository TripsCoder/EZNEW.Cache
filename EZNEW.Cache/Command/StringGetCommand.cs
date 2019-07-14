using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringGetCommand : CacheCommand<StringGetResponse>
    {
        /// <summary>
        /// keys
        /// </summary>
        public List<string> Keys
        {
            get; set;
        }

        protected override async Task<StringGetResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringGetAsync(server, this).ConfigureAwait(false);
        }
    }
}
