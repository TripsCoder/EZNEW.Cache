using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringGetRangeCommand : CacheCommand<StringGetRangeResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// start
        /// </summary>
        public long Start
        {
            get; set;
        }

        /// <summary>
        /// end
        /// </summary>
        public long End
        {
            get; set;
        }

        protected override async Task<StringGetRangeResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringGetRangeAsync(server, this).ConfigureAwait(false);
        }
    }
}
