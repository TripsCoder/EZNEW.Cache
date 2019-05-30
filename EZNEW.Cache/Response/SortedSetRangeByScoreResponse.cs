using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SortedSetRangeByScoreResponse:CacheResponse
    {
        /// <summary>
        /// members
        /// </summary>
        public List<string> Members
        {
            get; set;
        }
    }
}
