using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashIncrementCommand<T> : CacheCommand<HashIncrementResponse<T>>
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
        /// increment value
        /// </summary>
        public T IncrementValue
        {
            get; set;
        }

        protected override async Task<HashIncrementResponse<T>> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashIncrementAsync(server, this).ConfigureAwait(false);
        }
    }
}
