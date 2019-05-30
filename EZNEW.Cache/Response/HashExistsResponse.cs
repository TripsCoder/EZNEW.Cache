using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class HashExistsResponse:CacheResponse
    {
        /// <summary>
        /// has exists field
        /// </summary>
        public bool ExistsField
        {
            get;set;
        }
    }
}
