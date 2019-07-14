using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetLengthCommand : CacheCommand<SortedSetLengthResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// min
        /// </summary>
        public double Min
        {
            get; set;
        } = double.NegativeInfinity;

        /// <summary>
        /// max
        /// </summary>
        public double Max
        {
            get; set;
        } = double.PositiveInfinity;

        /// <summary>
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;

        protected override async Task<SortedSetLengthResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetLengthAsync(server, this).ConfigureAwait(false);
        }
    }
}
