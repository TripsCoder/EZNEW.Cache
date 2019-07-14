using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashDecrementCommand<T> : CacheCommand<HashDecrementResponse<T>>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// hash field
        /// </summary>
        public string HashField
        {
            get; set;
        }

        /// <summary>
        /// decrement value
        /// </summary>
        public T DecrementValue
        {
            get; set;
        }

        protected override async Task<HashDecrementResponse<T>> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashDecrementAsync(server, this).ConfigureAwait(false);
        }
    }
}
