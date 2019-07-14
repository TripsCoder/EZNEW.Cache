using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache.Command
{
    public interface ICacheCommand
    {
        /// <summary>
        /// cache object
        /// </summary>
        CacheObject CacheObject
        {
            get; set;
        }

        /// <summary>
        /// command flags
        /// </summary>
        CacheCommandFlags CommandFlags { get; set; }
    }
}
