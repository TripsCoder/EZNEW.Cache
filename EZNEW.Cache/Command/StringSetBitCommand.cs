using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringSetBitCommand : CacheCommand<StringSetBitResponse>
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
        /// Bit
        /// </summary>
        public bool Bit
        {
            get; set;
        }

        protected override async Task<StringSetBitResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringSetBitAsync(server, this).ConfigureAwait(false);
        }
    }
}
