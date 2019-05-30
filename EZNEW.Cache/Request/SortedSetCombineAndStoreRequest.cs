using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Request
{
    public class SortedSetCombineAndStoreRequest:CacheRequest
    {
        /// <summary>
        /// source keys
        /// </summary>
        public List<string> SourceKeys
        {
            get;set;
        }

        /// <summary>
        /// destination key
        /// </summary>
        public string DestinationKey
        {
            get;set;
        }

        /// <summary>
        /// set operation
        /// </summary>
        public SetOperationType SetOperation
        {
            get; set;
        } = SetOperationType.Union;

        /// <summary>
        /// weights
        /// </summary>
        public double[] Weights
        {
            get;set;
        }

        /// <summary>
        /// set aggregate
        /// </summary>
        public SetAggregate Aggregate
        {
            get; set;
        } = SetAggregate.Sum;
    }
}
