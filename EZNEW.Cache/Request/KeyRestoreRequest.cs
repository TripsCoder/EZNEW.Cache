using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class KeyRestoreRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// value
        /// </summary>
        public byte[] Value
        {
            get;set;
        }

        /// <summary>
        /// expiry
        /// </summary>
        public TimeSpan? Expiry
        {
            get;set;
        }
    }
}
