using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SortedSetRemoveRangeByScoreRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
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
        }

        /// <summary>
        /// stop score
        /// </summary>
        public double Stop
        {
            get; set;
        }

        /// <summary>
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;
    }
}
