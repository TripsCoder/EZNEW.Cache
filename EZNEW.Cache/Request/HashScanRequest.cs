using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class HashScanRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// pattern
        /// </summary>
        public string Pattern
        {
            get;set;
        }

        /// <summary>
        /// page size
        /// </summary>
        public int PageSize
        {
            get;set;
        }
    }
}
