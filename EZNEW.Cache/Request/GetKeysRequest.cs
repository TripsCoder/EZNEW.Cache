using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class GetKeysRequest:CacheRequest
    {
        /// <summary>
        /// key query
        /// </summary>
        public KeyQuery Query
        {
            get;set;
        }
    }
}
