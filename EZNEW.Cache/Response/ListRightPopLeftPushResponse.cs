using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListRightPopLeftPushResponse:CacheResponse
    {
        /// <summary>
        /// pop value
        /// </summary>
        public string PopValue
        {
            get;set;
        }
    }
}
