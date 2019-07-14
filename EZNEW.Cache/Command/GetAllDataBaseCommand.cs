using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class GetAllDataBaseCommand : CacheCommand<GetAllDataBaseResponse>
    {
        protected override async Task<GetAllDataBaseResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.GetAllDataBaseAsync(server, this).ConfigureAwait(false);
        }
    }
}
