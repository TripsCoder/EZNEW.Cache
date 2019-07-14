using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringIncrementResponse<T> : CacheResponse
    {
        /// <summary>
        /// new value
        /// </summary>
        public T NewValue
        {
            get; set;
        }
    }
}
