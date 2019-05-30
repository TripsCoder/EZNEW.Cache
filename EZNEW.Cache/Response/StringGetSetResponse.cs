using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringGetSetResponse:CacheResponse
    {
        /// <summary>
        /// old value
        /// </summary>
        public string OldValue
        {
            get;set;
        }
    }
}
