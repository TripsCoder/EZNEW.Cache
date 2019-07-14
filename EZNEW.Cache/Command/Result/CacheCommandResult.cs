using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZNEW.Cache.Command.Result
{
    /// <summary>
    /// cache command result
    /// </summary>
    public class CacheCommandResult<T>
    {
        /// <summary>
        /// responses
        /// </summary>
        public List<T> Responses
        {
            get; set;
        }

        /// <summary>
        /// add response
        /// </summary>
        /// <param name="responses"></param>
        public void AddResponse(params T[] responses)
        {
            if (responses == null || responses.Length < 1)
            {
                return;
            }
            Responses = Responses ?? new List<T>();
            Responses.AddRange(responses);
        }

        /// <summary>
        /// empty
        /// </summary>
        public static CacheCommandResult<T> EmptyResult()
        {
            return new CacheCommandResult<T>();
        }
    }
}
