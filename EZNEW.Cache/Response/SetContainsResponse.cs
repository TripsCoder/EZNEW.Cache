using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SetContainsResponse:CacheResponse
    {
        /// <summary>
        /// contains value
        /// </summary>
        public bool ContainsValue
        {
            get;set;
        }
    }
}
