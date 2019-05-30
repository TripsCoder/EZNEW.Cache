using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class GetKeysResponse : CacheResponse
    {
        /// <summary>
        /// keys
        /// </summary>
        public CachePaging<KeyItem> Keys
        {
            get;set;
        }
    }
}
