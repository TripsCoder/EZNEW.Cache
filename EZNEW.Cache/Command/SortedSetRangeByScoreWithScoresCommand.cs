using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetRangeByScoreWithScoresCommand : CacheCommand<SortedSetRangeByScoreWithScoresResponse>
    {
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// start score
        /// </summary>
        public double Start
        {
            get; set;
        } = double.MinValue;

        /// <summary>
        /// stop score
        /// </summary>
        public double Stop
        {
            get; set;
        } = double.MaxValue;

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
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;

        protected override async Task<SortedSetRangeByScoreWithScoresResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetRangeByScoreWithScoresAsync(server, this).ConfigureAwait(false);
        }
    }
}
