using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SortedSetLengthRequest:CacheRequest
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get; set;
        }

        /// <summary>
        /// min
        /// </summary>
        public double Min
        {
            get; set;
        } = double.NegativeInfinity;

        /// <summary>
        /// max
        /// </summary>
        public double Max
        {
            get; set;
        } = double.PositiveInfinity;

        /// <summary>
        /// exclude
        /// </summary>
        public SortedSetExclude Exclude
        {
            get; set;
        } = SortedSetExclude.None;
    }
}
