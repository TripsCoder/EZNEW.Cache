using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache.Config
{
    /// <summary>
    /// Cache Config
    /// </summary>
    public class CacheAppConfig
    {
        /// <summary>
        /// Cache Servers
        /// </summary>
        public Dictionary<string, CacheAppConfigItem> Servers
        {
            get;set;
        }
    }
}
