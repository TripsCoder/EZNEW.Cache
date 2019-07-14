using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetCombineCommand : CacheCommand<SetCombineResponse>
    {
        /// <summary>
        /// keys
        /// </summary>
        public List<string> Keys
        {
            get; set;
        }

        /// <summary>
        /// set operation
        /// </summary>
        public SetOperationType SetOperation
        {
            get; set;
        }

        protected override async Task<SetCombineResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetCombineAsync(server, this).ConfigureAwait(false);
        }
    }
}
