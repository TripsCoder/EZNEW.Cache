using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache.Response
{
    public class KeyExistsResponse : CacheResponse
    {
        /// <summary>
        /// key count
        /// </summary>
        public long KeyCount
        {
            get; set;
        }

        /// <summary>
        /// has key
        /// </summary>
        public bool HasKey
        {
            get
            {
                return KeyCount > 0;
            }
        }
    }
}
