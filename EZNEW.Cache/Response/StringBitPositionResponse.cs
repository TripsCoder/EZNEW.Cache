using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringBitPositionResponse:CacheResponse
    {
        /// <summary>
        /// position
        /// </summary>
        public long Position
        {
            get;set;
        }

        /// <summary>
        /// has found value
        /// </summary>
        public bool HasValue
        {
            get;set;
        }
    }
}
