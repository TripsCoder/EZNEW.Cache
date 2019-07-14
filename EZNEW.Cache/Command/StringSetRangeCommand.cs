using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZNEW.Cache.Response;

namespace EZNEW.Cache.Command
{
    public class StringSetRangeCommand : CacheCommand<StringSetRangeResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// offset
        /// </summary>
        public long Offset
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

        /// <summary>
        /// get execute handler
        /// </summary>
        /// <param name="cacheProvider">cache provider</param>
        /// <returns></returns>
        protected override async Task<StringSetRangeResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringSetRangeAsync(server, this).ConfigureAwait(false);
        }
    }
}
