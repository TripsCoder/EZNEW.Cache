using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringIncrementCommand<T> : CacheCommand<StringIncrementResponse<T>>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }


        public T Value
        {
            get; set;
        }

        protected override async Task<StringIncrementResponse<T>> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringIncrementAsync<T>(server, this).ConfigureAwait(false);
        }
    }
}
