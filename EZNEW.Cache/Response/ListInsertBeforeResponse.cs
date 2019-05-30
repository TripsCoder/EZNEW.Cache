using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache.Response
{
    public class ListInsertBeforeResponse:CacheResponse
    {
        /// <summary>
        /// the length of the list after the insert operation, or -1 when the value pivot was not found.
        /// </summary>
        public long NewListLength
        {
            get;set;
        }

        /// <summary>
        /// has insert
        /// </summary>
        public bool HasInsert
        {
            get;set;
        }
    }
}
