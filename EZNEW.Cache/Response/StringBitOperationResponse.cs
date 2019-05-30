using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class StringBitOperationResponse:CacheResponse
    {
        /// <summary>
        /// he size of the string stored in the destination key
        /// </summary>
        public long DestinationValueLength
        {
            get;set;
        }
    }
}
