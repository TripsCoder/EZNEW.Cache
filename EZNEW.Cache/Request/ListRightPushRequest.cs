﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ListRightPushRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// values
        /// </summary>
        public List<string> Values
        {
            get;set;
        }
    }
}