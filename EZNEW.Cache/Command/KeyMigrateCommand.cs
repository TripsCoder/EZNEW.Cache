using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyMigrateCommand : CacheCommand<KeyMigrateResponse>
    {
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// destination server
        /// </summary>
        public CacheServer DestinationServer
        {
            get; set;
        }

        /// <summary>
        /// time out milliseconds
        /// </summary>
        public int TimeOutMilliseconds
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        public CacheMigrateOptions MigrateOptions
        {
            get; set;
        } = CacheMigrateOptions.None;

        protected override async Task<KeyMigrateResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyMigrateAsync(server, this).ConfigureAwait(false);
        }
    }
}
