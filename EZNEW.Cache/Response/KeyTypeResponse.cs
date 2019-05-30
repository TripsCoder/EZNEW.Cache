using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class KeyTypeResponse:CacheResponse
    {
        /// <summary>
        /// key type
        /// </summary>
        public CacheKeyType KeyType
        {
            get;set;
        }
    }
}
