﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SortedSetIncrementResponse:CacheResponse
    {
        /// <summary>
        /// new score value
        /// </summary>
        public double NewScore
        {
            get;set;
        }
    }
}
