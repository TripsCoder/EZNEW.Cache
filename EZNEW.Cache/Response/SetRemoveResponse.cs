using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SetRemoveResponse:CacheResponse
    {
        /// <summary>
        /// remove count
        /// </summary>
        public long RemoveCount
        {
            get;set;
        }
    }
}
