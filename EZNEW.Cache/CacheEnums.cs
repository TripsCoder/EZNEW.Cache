using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{

    #region request

    /// <summary>
    /// request type
    /// </summary>
    public enum CacheRequestAndResponseType
    {
        Data = 110,
        Cmd = 120
    }

    #endregion

    /// <summary>
    /// ServerType
    /// </summary>
    public enum CacheServerType
    {
        NetCache = 310,
        Redis = 320,
        Memcached = 330
    }

    /// <summary>
    /// remove target type
    /// </summary>
    public enum RemoveTarget
    {
        Object = 110,
        Key = 120
    }

    /// <summary>
    /// list insert type
    /// </summary>
    public enum ListInsertType
    {
        Before = 210,
        After = 220
    }

    /// <summary>
    /// set operation type
    /// </summary>
    public enum SetOperationType
    {
        Union = 0,
        Intersect = 1,
        Difference = 2
    }

    /// <summary>
    /// sorted set exclude
    /// </summary>
    public enum SortedSetExclude
    {
        None = 0,
        Start = 1,
        Stop = 2,
        Both = 3
    }

    /// <summary>
    /// sorted order
    /// </summary>
    public enum SortedOrder
    {
        Ascending = 0,
        Descending = 1
    }

    /// <summary>
    /// key type
    /// </summary>
    public enum CacheKeyType
    {
        String = 1,
        Hash = 2,
        List = 3,
        Set = 4,
        SortedSet = 5
    }

    /// <summary>
    /// log level
    /// </summary>
    public enum LogLevel
    {
        Debug = 101,
        Verbose = 105,
        Notice = 110,
        Warning = 115
    }

    /// <summary>
    /// appendf sync
    /// </summary>
    public enum AppendfSync
    {
        No = 101,
        Always = 105,
        EverySecond = 110
    }

    /// <summary>
    /// cache command flags
    /// </summary>
    [Flags]
    public enum CacheCommandFlags
    {
        None = 0,
        PreferMaster = 0,
        HighPriority = 1,
        FireAndForget = 2,
        DemandMaster = 4,
        PreferSlave = 8,
        DemandSlave = 12,
        NoRedirect = 64,
        NoScriptCache = 512
    }

    [Flags]
    public enum CacheWhen
    {
        Always = 0,
        Exists = 1,
        NotExists = 2
    }

    public enum CacheBitwise
    {
        And = 0,
        Or = 1,
        Xor = 2,
        Not = 3
    }

    public enum SetAggregate
    {
        Sum = 0,
        Min = 1,
        Max = 2
    }

    public enum CacheSortType
    {
        Numeric = 0,
        Alphabetic = 1
    }

    public enum CacheMigrateOptions
    {
        None = 0,
        Copy = 1,
        Replace = 2
    }
}
