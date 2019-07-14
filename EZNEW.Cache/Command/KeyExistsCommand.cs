using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache.Command
{
    public class KeyExistsCommand : CacheCommand<KeyExistsResponse>
    {
        /// <summary>
        /// pattern key
        /// </summary>
        public List<string> keys
        {
            get;set;
        }

        protected override System.Threading.Tasks.Task<KeyExistsResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            throw new NotImplementedException();
        }
    }
}
