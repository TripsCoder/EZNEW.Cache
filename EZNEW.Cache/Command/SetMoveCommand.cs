using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetMoveCommand : CacheCommand<SetMoveResponse>
    {
        /// <summary>
        /// source key
        /// </summary>
        public string SourceKey
        {
            get; set;
        }

        /// <summary>
        /// destination key
        /// </summary>
        public string DestinationKey
        {
            get; set;
        }

        /// <summary>
        /// move value
        /// </summary>
        public string MoveValue
        {
            get; set;
        }

        protected override async Task<SetMoveResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetMoveAsync(server, this).ConfigureAwait(false);
        }
    }
}
