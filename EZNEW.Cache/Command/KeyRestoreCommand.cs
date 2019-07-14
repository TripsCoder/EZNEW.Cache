using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyRestoreCommand : CacheCommand<KeyRestoreResponse>
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
        public byte[] Value
        {
            get; set;
        }

        /// <summary>
        /// expiry
        /// </summary>
        public TimeSpan? Expiry
        {
            get; set;
        }

        protected override async Task<KeyRestoreResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyRestoreAsync(server, this).ConfigureAwait(false);
        }
    }
}
