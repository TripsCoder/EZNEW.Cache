using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListLengthResponse:CacheResponse
    {
        /// <summary>
        /// length
        /// </summary>
        public long Length
        {
            get;set;
        }
    }
}
