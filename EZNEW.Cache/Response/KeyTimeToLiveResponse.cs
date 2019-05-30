using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class KeyTimeToLiveResponse:CacheResponse
    {
        /// <summary>
        /// time to live
        /// </summary>
        public TimeSpan? TimeToLive
        {
            get;set;
        }
    }
}
