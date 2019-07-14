using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringSetCommand : CacheCommand<StringSetResponse>
    {
        /// <summary>
        /// 数据项
        /// </summary>
        public List<CacheDataItem> DataItems
        {
            get; set;
        }

        protected override async Task<StringSetResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringSetAsync(server, this).ConfigureAwait(false);
        }
    }
}
