using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SetCombineAndStoreResponse:CacheResponse
    {
        /// <summary>
        /// the number of elements in the resulting set.
        /// </summary>
        public long Count
        {
            get;set;
        }
    }
}
