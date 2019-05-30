using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListRightPushResponse:CacheResponse
    {
        /// <summary>
        /// the length of the list after the push operation.
        /// </summary>
        public long NewListLength
        {
            get;set;
        }
    }
}
