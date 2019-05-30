﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class StringGetRangeRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// start
        /// </summary>
        public long Start
        {
            get;set;
        }

        /// <summary>
        /// end
        /// </summary>
        public long End
        {
            get;set;
        }
    }
}
