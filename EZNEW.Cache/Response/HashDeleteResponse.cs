using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class HashDeleteResponse : CacheResponse
    {
        /// <summary>
        /// delete result
        /// </summary>
        public bool DeleteResult
        {
            get;set;
        }
    }
}
