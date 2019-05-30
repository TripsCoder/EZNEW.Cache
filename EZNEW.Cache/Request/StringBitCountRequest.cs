﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class StringBitCountRequest:CacheRequest
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
            get; set;
        } = 0;

        /// <summary>
        /// end
        /// </summary>
        public long End
        {
            get; set;
        } = -1;
    }
}
