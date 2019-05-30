using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ListTrimRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// start
        /// </summary>
        public long Start
        {
            get;set;
        }

        /// <summary>
        /// stop
        /// </summary>
        public long Stop
        {
            get;set;
        }
    }
}
