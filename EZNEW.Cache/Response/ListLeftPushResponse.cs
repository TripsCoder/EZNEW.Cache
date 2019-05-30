using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListLeftPushResponse:CacheResponse
    {
        /// <summary>
        /// the length of the list after the push operations.
        /// </summary>
        public long NewListLength
        {
            get;set;
        }
    }
}
