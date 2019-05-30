using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SortedSetScoreResponse:CacheResponse
    {
        /// <summary>
        /// score
        /// </summary>
        public double? Score
        {
            get;set;
        }
    }
}
