using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SortedSetRankResponse:CacheResponse
    {
        /// <summary>
        /// rank
        /// </summary>
        public long? Rank
        {
            get;set;
        }
    }
}
