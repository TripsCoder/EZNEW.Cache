using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZNEW.Cache.Response;

namespace EZNEW.Cache.Command
{
    public class ClearDataCommand : CacheCommand<ClearDataResponse>
    {
        /// <summary>
        /// clear data databaselist
        /// </summary>
        public List<CacheDb> DataBaseList
        {
            get; set;
        }

        protected override async Task<ClearDataResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ClearDataAsync(server, this).ConfigureAwait(false);
        }
    }
}
