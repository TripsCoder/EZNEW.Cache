﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class KeyPersistResponse:CacheResponse
    {
        /// <summary>
        /// operation result
        /// </summary>
        public bool OperationResult
        {
            get;set;
        }
    }
}
