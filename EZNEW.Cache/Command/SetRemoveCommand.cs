using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetRemoveCommand : CacheCommand<SetRemoveResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// remove value
        /// </summary>
        public List<string> RemoveValues
        {
            get; set;
        }

        protected override async Task<SetRemoveResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetRemoveAsync(server, this).ConfigureAwait(false);
        }
    }
}
