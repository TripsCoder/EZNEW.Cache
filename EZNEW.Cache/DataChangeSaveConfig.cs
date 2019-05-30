using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// data change save config
    /// </summary>
    public class DataChangeSaveConfig
    {
        /// <summary>
        /// time（seconds）
        /// </summary>
        public long Seconds
        {
            get;set;
        }

        /// <summary>
        /// changes number
        /// </summary>
        public long Changes
        {
            get;set;
        }
    }
}
