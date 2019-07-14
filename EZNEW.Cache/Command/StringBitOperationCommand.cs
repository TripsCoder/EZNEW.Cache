using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringBitOperationCommand : CacheCommand<StringBitOperationResponse>
    {
        /// <summary>
        /// bit wise
        /// </summary>
        public CacheBitwise Bitwise
        {
            get; set;
        }

        /// <summary>
        /// destination key for store
        /// </summary>
        public string DestinationKey
        {
            get; set;
        }

        /// <summary>
        /// operation keys
        /// </summary>
        public List<string> Keys
        {
            get; set;
        }

        protected override async Task<StringBitOperationResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringBitOperationAsync(server, this).ConfigureAwait(false);
        }
    }
}
