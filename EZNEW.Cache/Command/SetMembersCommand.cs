﻿using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SetMembersCommand : CacheCommand<SetMembersResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        protected override async Task<SetMembersResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SetMembersAsync(server, this).ConfigureAwait(false);
        }
    }
}
