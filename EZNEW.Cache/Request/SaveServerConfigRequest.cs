using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SaveServerConfigRequest:CacheRequest
    {
        /// <summary>
        /// config
        /// </summary>
        public CacheServerConfig ServerConfig
        {
            get;set;
        }
    }
}
