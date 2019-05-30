using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// server config
    /// </summary>
    public class CacheServerConfig
    {
        #region propertys

        /// <summary>
        /// Daemonize
        /// </summary>
        public bool Daemonize
        {
            get; set;
        }

        /// <summary>
        /// PidFile
        /// </summary>
        public string PidFile
        {
            get; set;
        }

        /// <summary>
        /// Port
        /// </summary>
        public int Port
        {
            get; set;
        }

        /// <summary>
        /// Host
        /// </summary>
        public string Host
        {
            get; set;
        }

        /// <summary>
        /// TimeOut
        /// </summary>
        public long TimeOut
        {
            get; set;
        }

        /// <summary>
        /// LogLevel
        /// </summary>
        public LogLevel LogLevel
        {
            get; set;
        }

        /// <summary>
        /// LogFile
        /// </summary>
        public string LogFile
        {
            get; set;
        }

        /// <summary>
        /// DataBase count
        /// </summary>
        public int DataBase
        {
            get; set;
        }

        /// <summary>
        /// SaveConfig
        /// </summary>
        public List<DataChangeSaveConfig> SaveConfig
        {
            get; set;
        }

        /// <summary>
        /// RdbCompression
        /// </summary>
        public bool RdbCompression
        {
            get; set;
        }

        /// <summary>
        /// DbFileName
        /// </summary>
        public string DbFileName
        {
            get; set;
        }

        /// <summary>
        /// DbDir
        /// </summary>
        public string DbDir
        {
            get; set;
        }

        /// <summary>
        /// MasterHost
        /// </summary>
        public string MasterHost
        {
            get; set;
        }

        /// <summary>
        /// MasterPort
        /// </summary>
        public int MasterPort
        {
            get; set;
        }

        /// <summary>
        /// MasterPwd
        /// </summary>
        public string MasterPwd
        {
            get; set;
        }

        /// <summary>
        /// Pwd
        /// </summary>
        public string Pwd
        {
            get; set;
        }

        /// <summary>
        /// MaxClient
        /// </summary>
        public int MaxClient
        {
            get; set;
        }

        /// <summary>
        /// MaxMemory
        /// </summary>
        public long MaxMemory
        {
            get; set;
        }

        /// <summary>
        /// AppendOnly
        /// </summary>
        public bool AppendOnly
        {
            get; set;
        }

        /// <summary>
        /// AppendFileName
        /// </summary>
        public string AppendFileName
        {
            get; set;
        }

        /// <summary>
        /// AppendfSync
        /// </summary>
        public AppendfSync AppendfSync
        {
            get; set;
        }

        /// <summary>
        /// EnabledVM
        /// </summary>
        public bool EnabledVM
        {
            get; set;
        }

        /// <summary>
        /// VMSwapFile
        /// </summary>
        public string VMSwapFile
        {
            get; set;
        }

        /// <summary>
        /// VMMaxMemory
        /// </summary>
        public long VMMaxMemory
        {
            get; set;
        }

        /// <summary>
        /// VMPageSize（Byte）
        /// </summary>
        public long VMPageSize
        {
            get; set;
        }

        /// <summary>
        /// VMPages
        /// </summary>
        public long VMPages
        {
            get; set;
        }

        /// <summary>
        /// VMMaxThreads
        /// </summary>
        public int VMMaxThreads
        {
            get; set;
        }

        /// <summary>
        /// Glueoutputbuf
        /// </summary>
        public bool Glueoutputbuf
        {
            get; set;
        }

        /// <summary>
        /// HashMaxZipMap
        /// </summary>
        public Dictionary<string, long> HashMaxZipMap
        {
            get; set;
        }

        /// <summary>
        /// ActivereHashing
        /// </summary>
        public bool ActivereHashing
        {
            get; set;
        }

        /// <summary>
        /// IncludeConfigFile
        /// </summary>
        public string IncludeConfigFile
        {
            get; set;
        }

        #endregion
    }
}
