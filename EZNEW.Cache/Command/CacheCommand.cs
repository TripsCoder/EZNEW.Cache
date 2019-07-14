using EZNEW.Cache.Command.Result;
using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    /// <summary>
    /// cache command
    /// </summary>
    public abstract class CacheCommand<TR> : ICacheCommand where TR : CacheResponse
    {
        /// <summary>
        /// cache object
        /// </summary>
        public CacheObject CacheObject
        {
            get; set;
        }

        /// <summary>
        /// command flags
        /// </summary>
        public CacheCommandFlags CommandFlags
        {
            get; set;
        } = CacheCommandFlags.None;

        /// <summary>
        /// execute
        /// </summary>
        /// <returns></returns>
        internal async Task<CacheCommandResult<TR>> ExecuteAsync()
        {
            var servers = GetCacheServers();
            if (servers == null)
            {
                return CacheCommandResult<TR>.EmptyResult();
            }
            CacheCommandResult<TR> result = new CacheCommandResult<TR>();
            foreach (var server in servers)
            {
                if (server == null)
                {
                    continue;
                }
                var provider = CacheManager.Config.GetCacheProvider(server.ServerType);
                if (provider == null)
                {
                    continue;
                }
                var response = await ExecuteCommandAsync(provider, server).ConfigureAwait(false);
                if (response != null)
                {
                    result.AddResponse(response);
                }
            }
            return result;
        }

        /// <summary>
        /// execute command
        /// </summary>
        /// <param name="server">server</param>
        /// <returns></returns>
        internal async Task<CacheCommandResult<TR>> ExecuteAsync(CacheServer server)
        {
            if (server == null)
            {
                return CacheCommandResult<TR>.EmptyResult();
            }
            var provider = CacheManager.Config.GetCacheProvider(server.ServerType);
            if (provider == null)
            {
                return CacheCommandResult<TR>.EmptyResult();
            }
            CacheCommandResult<TR> result = new CacheCommandResult<TR>();
            var response = await ExecuteCommandAsync(provider, server).ConfigureAwait(false);
            if (response != null)
            {
                result.AddResponse(response);
            }
            return result;
        }

        /// <summary>
        /// get execute handler
        /// </summary>
        /// <param name="cacheProvider">cache provider</param>
        /// <returns></returns>
        protected abstract Task<TR> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server);

        /// <summary>
        /// get cache servers
        /// </summary>
        /// <returns></returns>
        protected virtual List<CacheServer> GetCacheServers()
        {
            return CacheManager.Config.GetRequestCacheServers(this);
        }
    }
}
