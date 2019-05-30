using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SortedSetRangeByRankWithScoresResponse:CacheResponse
    {
        /// <summary>
        /// members
        /// </summary>
        public List<SortedSetValueItem> Members
        {
            get; set;
        }
    }
}
