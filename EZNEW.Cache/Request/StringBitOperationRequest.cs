using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class StringBitOperationRequest:CacheRequest
    {
        /// <summary>
        /// bit wise
        /// </summary>
        public CacheBitwise Bitwise
        {
            get;set;
        }

        /// <summary>
        /// destination key for store
        /// </summary>
        public string DestinationKey
        {
            get;set;
        }

        /// <summary>
        /// operation keys
        /// </summary>
        public List<string> Keys
        {
            get;set;
        }
    }
}
