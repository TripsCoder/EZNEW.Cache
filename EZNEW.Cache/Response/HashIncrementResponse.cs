using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class HashIncrementResponse<T>:CacheResponse
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// field
        /// </summary>
        public string HashField
        {
            get;set;
        }

        /// <summary>
        /// new value
        /// </summary>
        public T NewValue
        {
            get;set;
        }
    }
}
