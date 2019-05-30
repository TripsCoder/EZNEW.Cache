using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringGetWithExpiryResponse:CacheResponse
    {
        /// <summary>
        /// value
        /// </summary>
        public string Value
        {
            get;set;
        }

        /// <summary>
        /// expiry
        /// </summary>
        public TimeSpan? Expiry
        {
            get;set;
        }
    }
}
