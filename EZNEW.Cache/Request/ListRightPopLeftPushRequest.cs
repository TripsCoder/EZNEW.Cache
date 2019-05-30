using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class ListRightPopLeftPushRequest:CacheRequest
    {
        /// <summary>
        /// source key
        /// </summary>
        public string SourceKey
        {
            get;set;
        }

        /// <summary>
        /// destination key
        /// </summary>
        public string DestinationKey
        {
            get;set;
        }
    }
}
