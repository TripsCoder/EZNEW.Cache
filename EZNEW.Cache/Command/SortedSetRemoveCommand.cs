﻿using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Command
{
    public class SortedSetRemoveCommand : CacheCommand<SortedSetRemoveResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// remove members
        /// </summary>
        public List<string> RemoveMembers
        {
            get; set;
        }

        protected override async Task<SortedSetRemoveResponse> ExecuteCommandAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.SortedSetRemoveAsync(server, this).ConfigureAwait(false);
        }
    }
}
