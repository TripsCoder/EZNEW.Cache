using EZNEW.Framework.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZNEW.Cache
{
    /// <summary>
    /// cache key
    /// </summary>
    public class CacheKey
    {
        static readonly List<string> GlobalPrefixs = null;

        static CacheKey()
        {
            GlobalPrefixs = CacheManager.Config.SetGlobalCacheKeyPrefix?.Invoke();
        }

        /// <summary>
        /// key values
        /// </summary>
        SortedDictionary<string, string> nameValues = new SortedDictionary<string, string>();

        /// <summary>
        /// cache key value
        /// </summary>
        string actualCacheKey = string.Empty;

        /// <summary>
        /// is generated actual key
        /// </summary>
        bool generatedActualKey = false;

        /// <summary>
        /// add name
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="value">value</param>
        /// <returns></returns>
        public CacheKey AddName(string name, string value = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return this;
            }
            nameValues[name] = value;
            generatedActualKey = false;
            return this;
        }

        /// <summary>
        /// remove names
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public CacheKey RemoveNames(params string[] names)
        {
            if (names.IsNullOrEmpty())
            {
                return this;
            }
            foreach (var name in names)
            {
                nameValues.Remove(name);
            }
            generatedActualKey = false;
            return this;
        }

        /// <summary>
        /// get actual key
        /// </summary>
        /// <returns></returns>
        public string GetActualKey(CacheObject cacheObject = null)
        {
            if (generatedActualKey)
            {
                return actualCacheKey;
            }
            List<string> allKeys = new List<string>();

            //global keys
            if (!GlobalPrefixs.IsNullOrEmpty())
            {
                allKeys.AddRange(GlobalPrefixs);
            }
            //object keys
            var objectPrefixs = CacheManager.Config.SetCacheObjectKeyPrefix(cacheObject);
            if (!objectPrefixs.IsNullOrEmpty())
            {
                allKeys.AddRange(objectPrefixs);
            }
            if (!nameValues.IsNullOrEmpty())
            {
                allKeys.AddRange(nameValues.Select(c => c.Value.IsNullOrEmpty() ? c.Key : string.Format("{0}{1}{2}", c.Key, CacheManager.Config.NameValueSplitter, c.Value)));
            }
            actualCacheKey = string.Join(CacheManager.Config.KeyNameSplitter, allKeys);
            generatedActualKey = true;
            return actualCacheKey;
        }
    }
}
