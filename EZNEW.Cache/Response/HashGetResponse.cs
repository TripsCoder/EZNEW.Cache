using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class HashGetResponse:CacheResponse
    {
        /// <summary>
        /// value
        /// </summary>
        public string Value
        {
            get;set;
        }
    }
}
