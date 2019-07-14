using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListRightPushCommand : CacheCommand<ListRightPushResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// values
        /// </summary>
        public List<string> Values
        {
            get; set;
        }

        protected override async Task<ListRightPushResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListRightPushAsync(server, this).ConfigureAwait(false);
        }
    }
}
