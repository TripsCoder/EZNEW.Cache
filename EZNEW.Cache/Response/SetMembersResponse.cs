using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SetMembersResponse:CacheResponse
    {
        /// <summary>
        /// members
        /// </summary>
        public List<string> Members
        {
            get;set;
        }
    }
}
