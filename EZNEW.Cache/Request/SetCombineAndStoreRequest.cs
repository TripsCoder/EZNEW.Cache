using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SetCombineAndStoreRequest : CacheRequest
    {
        /// <summary>
        /// source keys
        /// </summary>
        public List<string> SourceKeys
        {
            get; set;
        }

        /// <summary>
        /// destination key
        /// </summary>
        public string DestinationKey
        {
            get;set;
        }

        /// <summary>
        /// set operation
        /// </summary>
        public SetOperationType SetOperation
        {
            get;set;
        }
    }
}
