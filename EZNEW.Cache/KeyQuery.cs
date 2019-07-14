using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// cache key query
    /// </summary>
    public class KeyQuery : CacheQuery
    {
        /// <summary>
        /// mate key
        /// </summary>
        public string MateKey
        {
            get; set;
        }

        /// <summary>
        /// key pattern type
        /// </summary>
        public KeyPatternType Type
        {
            get;set;
        }
    }
}
