using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringSetRangeResponse:CacheResponse
    {
        /// <summary>
        /// the value length after modified
        /// </summary>
        public long NewValueLength
        {
            get; set;
        }
    }
}
