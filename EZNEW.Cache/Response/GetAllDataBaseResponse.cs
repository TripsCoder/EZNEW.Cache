using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class GetAllDataBaseResponse:CacheResponse
    {
        /// <summary>
        /// database list
        /// </summary>
        public List<CacheDb> DataBaseList
        {
            get; set;
        }
    }
}
