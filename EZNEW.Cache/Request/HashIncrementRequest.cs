using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class HashIncrementRequest<T>:CacheRequest
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
        /// increment value
        /// </summary>
        public T IncrementValue
        {
            get;set;
        }
    }
}
