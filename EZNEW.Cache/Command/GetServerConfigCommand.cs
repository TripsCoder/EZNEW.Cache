using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class GetServerConfigCommand : CacheCommand<GetServerConfigResponse>
    {
        protected override async Task<GetServerConfigResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.GetServerConfigAsync(server, this).ConfigureAwait(false);
        }
    }
}
