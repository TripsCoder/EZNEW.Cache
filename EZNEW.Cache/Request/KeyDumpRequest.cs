﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class KeyDumpRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }
    }
}
