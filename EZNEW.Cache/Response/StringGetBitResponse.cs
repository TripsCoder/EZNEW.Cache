using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringGetBitResponse:CacheResponse
    {
        /// <summary>
        /// bit value
        /// </summary>
        public bool Bit
        {
            get;set;
        }
    }
}
