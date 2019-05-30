using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListRemoveResponse:CacheResponse
    {
        /// <summary>
        /// the number of removed elements.
        /// </summary>
        public long RemoveCount
        {
            get;set;
        }
    }
}
