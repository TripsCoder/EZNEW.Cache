using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ListInsertAfterRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// pivot value
        /// </summary>
        public string PivotValue
        {
            get; set;
        }

        /// <summary>
        /// insert value
        /// </summary>
        public string InsertValue
        {
            get; set;
        }
    }
}
