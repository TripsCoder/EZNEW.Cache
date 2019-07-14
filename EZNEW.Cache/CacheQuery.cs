using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    public class CacheQuery
    {
        protected int page = 1;//Page Index
        protected int pageSize = 20;//Page Size

        /// <summary>
        /// Page Index
        /// </summary>
        public int Page
        {
            get
            {
                if (page <= 0)
                {
                    page = 1;
                }
                return page;
            }
            set
            {
                page = value;
            }
        }

        /// <summary>
        /// Page Size
        /// </summary>
        public int PageSize
        {
            get
            {
                if (pageSize <= 0)
                {
                    pageSize = 20;
                }
                return pageSize;
            }
            set
            {
                pageSize = value;
            }
        }
    }
}
