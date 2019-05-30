using EZNEW.Cache.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache
{
    /// <summary>
    /// cache config manage
    /// </summary>
    public static class CacheConfig
    {
        /// <summary>
        /// cache engines
        /// </summary>
        public static Dictionary<CacheServerType, ICacheEngine> CacheEngines { get; } = new Dictionary<CacheServerType, ICacheEngine>();

        /// <summary>
        /// get or set the method to get cache servers
        /// </summary>
        public static Func<CacheRequest, CacheServer> GetCacheServersMethod
        {
            get; set;
        }

        /// <summary>
        /// get or ser the metho to verify the CacheOption object whether allow execute follow step
        /// </summary>
        public static Func<CacheRequest, bool> VerifyCacheOptionMethod
        {
            get; set;
        }

        /// <summary>
        /// generate CacheRequest object by CacheObject
        /// </summary>
        public static Func<CacheObject, CacheRequest> GenerateCacheRequestMethod
        {
            get; set;
        }
    }
}
