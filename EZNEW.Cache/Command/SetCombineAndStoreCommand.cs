using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetCombineAndStoreCommand : CacheCommand<SetCombineAndStoreResponse>
    {
        /// <summary>
        /// source keys
        /// </summary>
        public List<string> SourceKeys
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

        /// <summary>
        /// set operation
        /// </summary>
        public SetOperationType SetOperation
        {
            get; set;
        }

        protected override async Task<SetCombineAndStoreResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetCombineAndStoreAsync(server, this).ConfigureAwait(false);
        }
    }
}
