using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// cache paging
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CachePaging<T> : IEnumerable<T>
    {
        private T[] items = new T[0];//datas

        #region Constructor

        /// <summary>
        /// Instance a paging object
        /// </summary>
        /// <param name="page">page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="totalCount">total data</param>
        /// <param name="items">datas</param>
        public CachePaging(long page, long pageSize, long totalCount, IEnumerable<T> items)
        {
            if (items == null)
            {
                return;
            }

            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
            this.items = items.ToArray();
            if (pageSize > 0)
            {
                PageCount = totalCount / pageSize;
                if (totalCount % pageSize > 0)
                {
                    PageCount++;
                }
            }
        }

        #endregion

        #region propertys

        /// <summary>
        /// Page Size
        /// </summary>
        public long PageSize
        {
            get; set;
        }

        /// <summary>
        /// Page
        /// </summary>
        public long Page
        {
            get; set;
        }

        /// <summary>
        /// Total Count
        /// </summary>
        public long TotalCount
        {
            get; set;
        }

        /// <summary>
        /// Page Count
        /// </summary>
        public long PageCount
        {
            get; set;
        }

        #endregion

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Return a Empty Paging Object
        /// </summary>
        /// <returns></returns>
        public static CachePaging<T> EmptyPaging()
        {
            return new CachePaging<T>(1, 0, 0, null);
        }
    }
}
