using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    /// <summary>
    /// cache request information
    /// </summary>
    public abstract class CacheRequest
    {
        /// <summary>
        /// cache server
        /// </summary>
        public CacheServer Server
        {
            get;set;
        }

        /// <summary>
        /// cache object
        /// </summary>
        public CacheObject CacheObject
        {
            get;set;
        }

        /// <summary>
        /// command flags
        /// </summary>
        public CacheCommandFlags CommandFlags
        {
            get; set;
        } = CacheCommandFlags.None;
    }
}
