using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class KeyDeleteResponse:CacheResponse
    {
        /// <summary>
        /// delete count
        /// </summary>
        public long DeleteCount
        {
            get;set;
        }
    }
}
