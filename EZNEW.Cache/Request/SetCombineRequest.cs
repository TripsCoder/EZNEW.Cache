using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SetCombineRequest:CacheRequest
    {
        /// <summary>
        /// keys
        /// </summary>
        public List<string> Keys
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
