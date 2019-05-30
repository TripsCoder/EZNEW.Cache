using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class KeyRenameResponse:CacheResponse
    {
        /// <summary>
        /// rename result
        /// </summary>
        public bool RenameResult
        {
            get;set;
        }
    }
}
