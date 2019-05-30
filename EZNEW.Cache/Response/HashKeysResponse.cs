using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class HashKeysResponse:CacheResponse
    {
        /// <summary>
        /// hash keys
        /// </summary>
        public List<string> HashKeys
        {
            get;set;
        }
    }
}
