using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// Cache Server
    /// </summary>
    public class CacheServer
    {
        SortedDictionary<string, dynamic> serverConfig = new SortedDictionary<string, dynamic>();
        CacheServerType serverType;
        bool initKey = false;
        string key = string.Empty;

        #region propertys

        /// <summary>
        /// server type
        /// </summary>
        public CacheServerType ServerType
        {
            get
            {
                return serverType;
            }
            set
            {
                RemoveKey();
                serverType = value;
            }
        }

        /// <summary>
        /// host
        /// </summary>
        public string Host
        {
            get
            {
                return GetConfigValue<string>("Host");
            }
            set
            {
                SetConfigValue<string>("Host", value);
            }
        }

        /// <summary>
        /// port
        /// </summary>
        public int Port
        {
            get
            {
                return GetConfigValue<int>("Port");
            }
            set
            {
                SetConfigValue<int>("Port", value);
            }
        }

        /// <summary>
        /// database
        /// </summary>
        public string Db { get; set; } = string.Empty;

        /// <summary>
        /// username
        /// </summary>
        public string UserName
        {
            get
            {
                return GetConfigValue<string>("UserName");
            }
            set
            {
                SetConfigValue<string>("UserName", value);
            }
        }

        /// <summary>
        /// pwd
        /// </summary>
        public string Pwd
        {
            get
            {
                return GetConfigValue<string>("Pwd");
            }
            set
            {
                SetConfigValue<string>("Pwd", value);
            }
        }

        /// <summary>
        /// allow admin
        /// </summary>
        public bool AllowAdmin
        {
            get
            {
                return GetConfigValue<bool>("AllowAdmin");
            }
            set
            {
                SetConfigValue<bool>("AllowAdmin", value);
            }
        }

        /// <summary>
        /// connect timeout
        /// </summary>
        public int ConnectTimeout
        {
            get
            {
                return GetConfigValue<int>("ConnectTimeout");
            }
            set
            {
                SetConfigValue<int>("ConnectTimeout", value);
            }
        }

        /// <summary>
        /// client name
        /// </summary>
        public string ClientName
        {
            get
            {
                return GetConfigValue<string>("ClientName");
            }
            set
            {
                SetConfigValue<string>("ClientName", value);
            }
        }

        /// <summary>
        /// dns
        /// </summary>
        public bool ResolveDns
        {
            get
            {
                return GetConfigValue<bool>("ResolveDns");
            }
            set
            {
                SetConfigValue<bool>("ResolveDns", value);
            }
        }

        /// <summary>
        /// ssl
        /// </summary>
        public bool SSL
        {
            get
            {
                return GetConfigValue<bool>("SSL");
            }
            set
            {
                SetConfigValue<bool>("SSL", value);
            }
        }

        /// <summary>
        /// ssl host
        /// </summary>
        public string SSLHost
        {
            get
            {
                return GetConfigValue<string>("SSLHost");
            }
            set
            {
                SetConfigValue<string>("SSLHost", value);
            }
        }

        /// <summary>
        /// sync timeout(ms)
        /// </summary>
        public int SyncTimeout
        {
            get
            {
                return GetConfigValue<int>("SyncTimeout");
            }
            set
            {
                SetConfigValue<int>("SyncTimeout", value);
            }
        }

        /// <summary>
        /// tiebreaker(master key)
        /// </summary>
        public string TieBreaker
        {
            get
            {
                return GetConfigValue<string>("TieBreaker");
            }
            set
            {
                SetConfigValue<string>("TieBreaker", value);
            }
        }

        /// <summary>
        /// write buffer
        /// </summary>
        public int WriteBuffer
        {
            get
            {
                return GetConfigValue<int>("WriteBuffer");
            }
            set
            {
                SetConfigValue<int>("WriteBuffer", value);
            }
        }

        /// <summary>
        /// identity key
        /// </summary>
        public string IdentityKey
        {
            get
            {
                return GetServerKey();
            }
        }

        #endregion

        #region methods

        /// <summary>
        /// set server config value
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="value">value</param>
        void SetConfigValue<T>(string name, T value)
        {
            RemoveKey();
            if (serverConfig.ContainsKey(name))
            {
                serverConfig[name] = value;
            }
            else
            {
                serverConfig.Add(name, value);
            }
        }

        /// <summary>
        /// get config value
        /// </summary>
        /// <param name="name">name</param>
        /// <returns></returns>
        T GetConfigValue<T>(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !serverConfig.ContainsKey(name))
            {
                return default(T);
            }
            return serverConfig[name];
        }

        /// <summary>
        /// get server identity key
        /// </summary>
        /// <returns></returns>
        string GetServerKey()
        {
            if (initKey)
            {
                return key;
            }
            if (serverConfig == null)
            {
                return string.Empty;
            }
            List<string> valueItems = new List<string>();
            foreach (var configItem in serverConfig)
            {
                valueItems.Add(string.Format("{0}_{1}", configItem.Key, configItem.Value));
            }
            key = string.Join(",", valueItems);
            initKey = true;
            return key;
        }

        /// <summary>
        /// clear identity key
        /// </summary>
        void RemoveKey()
        {
            initKey = false;
            key = string.Empty;
        }

        public override bool Equals(object obj)
        {
            CacheServer objServer = obj as CacheServer;
            if (objServer == null)
            {
                return false;
            }
            return objServer.IdentityKey == IdentityKey;
        }

        public override int GetHashCode()
        {
            return IdentityKey.GetHashCode();
        }

        #endregion
    }
}
