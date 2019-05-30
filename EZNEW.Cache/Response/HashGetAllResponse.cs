using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class HashGetAllResponse:CacheResponse
    {
        /// <summary>
        /// hash values
        /// </summary>
        public Dictionary<string, string> HashValues
        {
            get;set;
        }
    }
}
