using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringAppendResponse : CacheResponse
    {
        /// <summary>
        /// the length of the string after the append operation.
        /// </summary>
        public long NewValueLength
        {
            get;set;
        }
    }
}
