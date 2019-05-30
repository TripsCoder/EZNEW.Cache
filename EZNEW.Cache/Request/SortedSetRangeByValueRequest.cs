using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SortedSetRangeByValueRequest:CacheRequest
    {
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// min value
        /// </summary>
        public string MinValue
        {
            get;set;
        }

        /// <summary>
        /// max value
        /// </summary>
        public string MaxValue
        {
            get;set;
        }

        /// <summary>
        /// skip
        /// </summary>
        public long Skip
        {
            get; set;
        }= 0;

        /// <summary>
        /// take
        /// </summary>
        public long Take
        {
            get; set;
        } = -1;

        /// <summary>
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;
    }
}
