﻿using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class KeyDumpCommand : CacheCommand<KeyDumpResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        protected override async Task<KeyDumpResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.KeyDumpAsync(server, this).ConfigureAwait(false);
        }
    }
}
