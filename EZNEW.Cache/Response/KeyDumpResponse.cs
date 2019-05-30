using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class KeyDumpResponse:CacheResponse
    {
        /// <summary>
        /// values
        /// </summary>
        public byte[] ByteValues
        {
            get;set;
        }
    }
}
