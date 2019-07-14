using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyMoveCommand : CacheCommand<KeyMoveResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// database
        /// </summary>
        public int DataBase
        {
            get; set;
        }

        protected override async Task<KeyMoveResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyMoveAsync(server, this).ConfigureAwait(false);
        }
    }
}
