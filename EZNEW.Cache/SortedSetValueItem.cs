using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// set value
    /// </summary>
    public class SortedSetValueItem
    {
        #region propertys

        /// <summary>
        /// value
        /// </summary>
        public string Value
        {
            get; set;
        }

        /// <summary>
        /// score
        /// </summary>
        public double Score
        {
            get; set;
        }

        #endregion
    }
}
