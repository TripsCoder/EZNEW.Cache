using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListRangeCommand : CacheCommand<ListRangeResponse>
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
        /// stop
        /// </summary>
        public long Stop
        {
            get; set;
        } = -1;

        protected override async Task<ListRangeResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListRangeAsync(server, this).ConfigureAwait(false);
        }
    }
}
