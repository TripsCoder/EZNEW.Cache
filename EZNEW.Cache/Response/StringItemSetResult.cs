using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    /// <summary>
    /// string set valoue result
    /// </summary>
    public class StringItemSetResult
    {
        /// <summary>
        /// key
        /// </summary>
        public string Key
        {
            get;set;
        }

        /// <summary>
        /// set success
        /// </summary>
        public bool SetSuccess
        {
            get;set;
        }
    }
}
