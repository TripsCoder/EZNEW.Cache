using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListTrimCommand : CacheCommand<ListTrimResponse>
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
        /// stop
        /// </summary>
        public long Stop
        {
            get; set;
        }

        protected override async Task<ListTrimResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListTrimAsync(server, this).ConfigureAwait(false);
        }
    }
}
