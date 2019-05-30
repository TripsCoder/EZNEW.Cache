using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ClearDataRequest:CacheRequest
    {
        /// <summary>
        /// clear data databaselist
        /// </summary>
        public List<CacheDb> DataBaseList
        {
            get;set;
        }
    }
}
