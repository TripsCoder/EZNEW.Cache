using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class StringSetRequest:CacheRequest
    {
        /// <summary>
        /// 数据项
        /// </summary>
        public List<KeyItem> DataItems
        {
            get;set;
        }
    }
}
