using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// remove key
    /// </summary>
    public class RemoveKey
    {
        /// <summary>
        /// keys
        /// </summary>
        public List<string> Keys
        {
            get;set;
        }

        /// <summary>
        /// db index
        /// </summary>
        public int DbIndex
        {
            get;set;
        }
    }
}
