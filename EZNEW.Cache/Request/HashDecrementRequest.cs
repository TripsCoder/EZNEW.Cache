using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class HashDecrementRequest<T>:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// hash field
        /// </summary>
        public string HashField
        {
            get;set;
        }

        /// <summary>
        /// decrement value
        /// </summary>
        public T DecrementValue
        {
            get;set;
        }
    }
}
