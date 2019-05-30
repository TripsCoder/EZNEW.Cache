using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class SetCombineResponse:CacheResponse
    {
        /// <summary>
        /// combine values
        /// </summary>
        public List<string> CombineValues
        {
            get;set;
        }
    }
}
