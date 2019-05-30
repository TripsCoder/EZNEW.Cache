using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class StringSetBitRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// offset
        /// </summary>
        public long Offset
        {
            get;set;
        }

        /// <summary>
        /// Bit
        /// </summary>
        public bool Bit
        {
            get;set;
        }
    }
}
