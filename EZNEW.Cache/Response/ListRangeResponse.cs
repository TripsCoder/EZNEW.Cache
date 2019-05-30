using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListRangeResponse:CacheResponse
    {
        /// <summary>
        /// values
        /// </summary>
        public List<string> Values
        {
            get;set;
        }
    }
}
