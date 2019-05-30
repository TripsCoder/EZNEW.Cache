using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    public class CacheQuery
    {
        protected int _page = 1;//Page Index
        protected int _pageSize = 20;//Page Size

        /// <summary>
        /// Page Index
        /// </summary>
        public int Page
        {
            get
            {
                if (_page <= 0)
                {
                    _page = 1;
                }
                return _page;
            }
            set
            {
                _page = value;
            }
        }

        /// <summary>
        /// Page Size
        /// </summary>
        public int PageSize
        {
            get
            {
                if (_pageSize <= 0)
                {
                    _pageSize = 20;
                }
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
    }
}
