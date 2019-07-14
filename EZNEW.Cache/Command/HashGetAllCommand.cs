﻿using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class HashGetAllCommand : CacheCommand<HashGetAllResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        protected override async Task<HashGetAllResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.HashGetAllAsync(server, this).ConfigureAwait(false);
        }
    }
}
