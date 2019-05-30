using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SetMoveRequest:CacheRequest
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

        /// <summary>
        /// move value
        /// </summary>
        public string MoveValue
        {
            get;set;
        }
    }
}
