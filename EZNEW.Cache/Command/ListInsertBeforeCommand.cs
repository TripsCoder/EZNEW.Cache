using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class ListInsertBeforeCommand : CacheCommand<ListInsertBeforeResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// pivot value
        /// </summary>
        public string PivotValue
        {
            get; set;
        }

        /// <summary>
        /// insert value
        /// </summary>
        public string InsertValue
        {
            get; set;
        }

        protected override async Task<ListInsertBeforeResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.ListInsertBeforeAsync(server, this).ConfigureAwait(false);
        }
    }
}
