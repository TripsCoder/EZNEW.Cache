using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortAndStoreCommand : CacheCommand<SortAndStoreResponse>
    {
        /// <summary>
        /// destination key
        /// </summary>
        public string DestinationKey
        {
            get; set;
        }

        /// <summary>
        /// key
        /// </summary>
        public string SourceKey
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

        protected override async Task<SortAndStoreResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortAndStoreAsync(server, this).ConfigureAwait(false);
        }
    }
}
