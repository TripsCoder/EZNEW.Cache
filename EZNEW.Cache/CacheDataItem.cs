using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// value item
    /// </summary>
    public class CacheDataItem
    {
        /// <summary>
        /// key
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// data type
        /// </summary>
        public CacheKeyType Type
        {
            get; set;
        }

        /// <summary>
        /// value
        /// </summary>
        public object Value
        {
            get; set;
        }

        /// <summary>
        /// expiration（seconds）
        /// </summary>
        public long Seconds
        {
            get; set;
        }

        /// <summary>
        /// set value condition
        /// </summary>
        public CacheWhen SetCondition
        {
            get; set;
        } = CacheWhen.Always;
    }
}
