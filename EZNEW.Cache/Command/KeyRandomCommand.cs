using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyRandomCommand : CacheCommand<KeyRandomResponse>
    {
        protected override async Task<KeyRandomResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyRandomAsync(server, this).ConfigureAwait(false);
        }
    }
}
