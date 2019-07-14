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
        /// inner response
        /// </summary>
        public List<CacheResponse> InnerResponses
        {
            get;
            protected set;
        }

        #endregion

        /// <summary>
        /// add inner response
        /// </summary>
        /// <param name="innerResponses">inner responses</param>
        public void AddInnerResponse(params CacheResponse[] innerResponses)
        {
            InnerResponses = InnerResponses ?? new List<CacheResponse>();
            if (innerResponses != null && innerResponses.Length > 0)
            {
                InnerResponses.AddRange(innerResponses);
            }
        }

        /// <summary>
        /// get empty response
        /// </summary>
        /// <returns></returns>
        public static CacheResponse Empty()
        {
            return new CacheResponse();
        }
    }
}
