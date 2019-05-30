using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ListRemoveRequest:CacheRequest
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
        public string Value
        {
            get;set;
        }

        /// <summary>
        /// Count
        /// </summary>
        public long Count
        {
            get; set;
        } = 0;
    }
}
