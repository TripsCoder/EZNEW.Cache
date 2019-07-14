using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetRangeByValueCommand : CacheCommand<SortedSetRangeByValueResponse>
    {
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// min value
        /// </summary>
        public string MinValue
        {
            get; set;
        }

        /// <summary>
        /// max value
        /// </summary>
        public string MaxValue
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
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;

        protected override async Task<SortedSetRangeByValueResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetRangeByValueAsync(server, this).ConfigureAwait(false);
        }
    }
}
