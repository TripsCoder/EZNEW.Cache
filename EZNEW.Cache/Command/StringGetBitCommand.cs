﻿using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class StringGetBitCommand : CacheCommand<StringGetBitResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// offset
        /// </summary>
        public long Offset
        {
            get; set;
        }

        protected override async Task<StringGetBitResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringGetBitAsync(server, this).ConfigureAwait(false);
        }
    }
}
