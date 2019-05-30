using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class GetKeyDetailResponse:CacheResponse
    {
        /// <summary>
        /// key detail
        /// </summary>
        public KeyItem KeyDetail
        {
            get;set;
        }
    }
}
