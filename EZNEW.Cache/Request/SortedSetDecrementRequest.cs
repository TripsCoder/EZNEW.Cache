using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SortedSetDecrementRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// member
        /// </summary>
        public string Member
        {
            get; set;
        }

        /// <summary>
        /// score value
        /// </summary>
        public double DecrementScore
        {
            get; set;
        }
    }
}
