using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetRandomMembersCommand : CacheCommand<SetRandomMembersResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// count
        /// </summary>
        public long Count
        {
            get; set;
        }

        protected override async Task<SetRandomMembersResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetRandomMembersAsync(server, this).ConfigureAwait(false);
        }
    }
}
