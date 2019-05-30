using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    /// <summary>
    /// string value set response
    /// </summary>
    public class StringSetResponse:CacheResponse
    {
        /// <summary>
        /// set results
        /// </summary>
        public List<StringItemSetResult> SetResults
        {
            get;set;
        }
    }
}
