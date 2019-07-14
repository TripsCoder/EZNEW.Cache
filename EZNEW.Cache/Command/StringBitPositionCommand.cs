using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringBitPositionCommand : CacheCommand<StringBitPositionResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// bit
        /// </summary>
        public bool Bit
        {
            get; set;
        }

        /// <summary>
        /// start
        /// </summary>
        public long Start
        {
            get; set;
        } = 0;

        /// <summary>
        /// end
        /// </summary>
        public long End
        {
            get; set;
        } = -1;

        protected override async Task<StringBitPositionResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringBitPositionAsync(server, this).ConfigureAwait(false);
        }
    }
}
