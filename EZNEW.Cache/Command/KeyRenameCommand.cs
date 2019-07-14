using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyRenameCommand : CacheCommand<KeyRenameResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// new key
        /// </summary>
        public string NewKey
        {
            get; set;
        }

        /// <summary>
        /// time condition
        /// </summary>
        public CacheWhen When
        {
            get; set;
        } = CacheWhen.Always;

        protected override async Task<KeyRenameResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyRenameAsync(server, this).ConfigureAwait(false);
        }
    }
}
