using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringBitCountResponse:CacheResponse
    {
        /// <summary>
        /// The number of bits set to 1
        /// </summary>
        public long BitNum
        {
            get;set;
        }
    }
}
