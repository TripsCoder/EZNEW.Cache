using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache.Response
{
    /// <summary>
    /// cache response
    /// </summary>
    public class CacheResponse
    {
        #region propertys

        /// <summary>
        /// is success
        /// </summary>
        public bool Success
        {
            get;
            set;
        }

        /// <summary>
        /// message
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// response code
        /// </summary>
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// child response
        /// </summary>
        public List<CacheResponse> ChildResponses
        {
            get;
            protected set;
        }

        #endregion

        /// <summary>
        /// add child response
        /// </summary>
        /// <param name="childResponses"></param>
        public void AddChildResponse(params CacheResponse[] childResponses)
        {
            ChildResponses = ChildResponses ?? new List<CacheResponse>();
            if (childResponses!=null&&childResponses.Length>0)
            {
                ChildResponses.AddRange(childResponses);
            }
        }
    }
}
