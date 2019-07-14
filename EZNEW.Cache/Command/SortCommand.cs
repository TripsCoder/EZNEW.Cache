using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortCommand : CacheCommand<SortResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// skip
        /// </summary>
        public long Skip
        {
            get; set;
        } = 0;

        /// <summary>
        /// take
        /// </summary>
        public long Take
        {
            get; set;
        } = -1;

        /// <summary>
        /// order
        /// </summary>
        public SortedOrder Order
        {
            get; set;
        } = SortedOrder.Ascending;

        /// <summary>
        /// sort type
        /// </summary>
        public CacheSortType SortType
        {
            get; set;
        } = CacheSortType.Numeric;

        /// <summary>
        /// sort by value
        /// </summary>
        public string By
        {
            get; set;
        }

        /// <summary>
        /// get values
        /// </summary>
        public List<string> Gets
        {
            get; set;
        }

        protected override async Task<SortResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortAsync(server, this).ConfigureAwait(false);
        }
    }
}
