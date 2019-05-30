using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SortedSetCombineAndStoreResponse:CacheResponse
    {
        /// <summary>
        /// new set length
        /// </summary>
        public long NewSetLength
        {
            get;set;
        }
    }
}
