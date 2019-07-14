using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringBitCountCommand : CacheCommand<StringBitCountResponse>
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
        } = 0;

        /// <summary>
        /// end
        /// </summary>
        public long End
        {
            get; set;
        } = -1;

        protected override async Task<StringBitCountResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringBitCountAsync(server, this).ConfigureAwait(false);
        }
    }
}
