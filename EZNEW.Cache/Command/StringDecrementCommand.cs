using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringDecrementCommand<T> : CacheCommand<StringDecrementResponse<T>>
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
        public T Value
        {
            get; set;
        }

        protected override async Task<StringDecrementResponse<T>> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringDecrementAsync<T>(server, this).ConfigureAwait(false);
        }
    }
}
