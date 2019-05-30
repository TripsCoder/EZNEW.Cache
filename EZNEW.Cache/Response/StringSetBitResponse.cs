using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringSetBitResponse:CacheResponse
    {
        /// <summary>
        /// the original bit value stored at offset
        /// </summary>
        public bool OldBitValue
        {
            get;set;
        }
    }
}
