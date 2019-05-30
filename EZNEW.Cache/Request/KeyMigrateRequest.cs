using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class KeyMigrateRequest:CacheRequest
    {
        public string Key
        {
            get;set;
        }
        
        /// <summary>
        /// destination server
        /// </summary>
        public CacheServer DestinationServer
        {
            get;set;
        }

        /// <summary>
        /// time out milliseconds
        /// </summary>
        public int TimeOutMilliseconds
        {
            get;set;
        }

        /// <summary>
        /// 
        /// </summary>
        public CacheMigrateOptions MigrateOptions
        {
            get; set;
        } = CacheMigrateOptions.None;
    }
}
