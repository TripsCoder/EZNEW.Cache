using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class KeyRenameRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// new key
        /// </summary>
        public string NewKey
        {
            get;set;
        }

        /// <summary>
        /// time condition
        /// </summary>
        public CacheWhen When
        {
            get; set;
        } = CacheWhen.Always;
    }
}
