using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class GetServerConfigResponse:CacheResponse
    {
        /// <summary>
        /// server config
        /// </summary>
        public CacheServerConfig ServerConfig
        {
            get;set;
        }
    }
}
