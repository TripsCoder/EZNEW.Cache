using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListRemoveCommand : CacheCommand<ListRemoveResponse>
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

        /// <summary>
        /// Count
        /// </summary>
        public long Count
        {
            get; set;
        } = 0;

        protected override async Task<ListRemoveResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListRemoveAsync(server, this).ConfigureAwait(false);
        }
    }
}
