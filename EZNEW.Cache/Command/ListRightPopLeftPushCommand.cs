using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListRightPopLeftPushCommand : CacheCommand<ListRightPopLeftPushResponse>
    {
        /// <summary>
        /// source key
        /// </summary>
        public string SourceKey
        {
            get; set;
        }

        /// <summary>
        /// destination key
        /// </summary>
        public string DestinationKey
        {
            get; set;
        }

        protected override async Task<ListRightPopLeftPushResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListRightPopLeftPushAsync(server, this).ConfigureAwait(false);
        }
    }
}
