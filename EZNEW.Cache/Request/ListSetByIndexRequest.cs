using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ListSetByIndexRequest : CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// index
        /// </summary>
        public long Index
        {
            get;set;
        }

        /// <summary>
        /// value
        /// </summary>
        public string Value
        {
            get;set;
        }
    }
}
