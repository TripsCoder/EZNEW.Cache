﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringGetResponse:CacheResponse
    {
        /// <summary>
        /// values
        /// </summary>
        public List<KeyItem> Values
        {
            get;set;
        }
    }
}