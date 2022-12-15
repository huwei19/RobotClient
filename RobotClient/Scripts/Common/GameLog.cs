/********************************************************************
	description:	
        游戏日志工具
        1.支持将日志写入控制台、文件或DebugInfo面板
        2.通过logMessageReceived的方式扩展，因此不强制要求必须使用GameLog接口
        3.日志文件写入缓存，通过最低时间间隔（GlobeVar.logFileFlushInterval)或池已占用比率(GlobeVar.logFileFlushRate)来刷新到文件
        4.特别的，此工具不支持多线程(无锁)
*********************************************************************/

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

using Games.GlobeDefine;

public class GameLog
{
    // 是否已初始化
    private static bool _is_inited = false;
    // 日志文件路径
    private static string _log_file_path = "";

    // 缓存空间
    private static int _cache_max_size = GlobeVar.logFileCacheSize;
    private static byte[] _cache_pool = null;
    private static int _cache_pool_size = 0;

    // 日志前缀，只用于写到文件时
    private static Dictionary<LogType, string> _logPrefix = new Dictionary<LogType, string>();
    // 上一次写入到文件的时间戳 （毫秒）
    private static double _last_flush_ts = GlobeVar.INVALID_ID;

    //gamelog所以对应的机器人批次
    private static int _robotIdx = 1;
    //命令行批次
    private static int _robotbatch = 1;

    /// <summary>
    /// Log 的类别
    /// </summary>
    public enum LogType
    {
        Error,
        Assert,
        Warning,
        Log,
        Exception,
    }

    static GameLog()
    {
        _is_inited = false;
        _cache_pool_size = 0;
        _cache_max_size = GlobeVar.logFileCacheSize;
        _cache_pool = new byte[_cache_max_size];
        _robotIdx = 1;
        _robotbatch = 1;

        _logPrefix.Add(LogType.Error, "[Err]");
        _logPrefix.Add(LogType.Assert, "[Asrt]");
        _logPrefix.Add(LogType.Warning, "[Warn]");
        _logPrefix.Add(LogType.Log, "[Log]");
        _logPrefix.Add(LogType.Exception, "[Excp]");
    }

    /// <summary>
    /// 注册log文件日志，需要再机器人工厂创建时执行
    /// </summary>
    /// <param name="robotIdx">机器人批次</param>
    public static void RegisterLog(int robotbatch, int robotIdx)
    {
        _cache_pool_size = 0;

        if (!Directory.Exists("log"))
        {
            Directory.CreateDirectory("log");
        }
        _robotIdx = robotIdx;
        _robotbatch = robotbatch;

        _log_file_path = string.Format("./log/Robot_{0}_{1}_{2}.log", robotbatch, robotIdx, DateTime.Now.ToString("yyyyMMdd"));
        CheckLogFile(_log_file_path);

        _is_inited = true;

        // 写入日志头
        GameLog.Log("-----------------Robot.log---------------");
    }

    /// <summary>
    /// 跨天 就重新创建新的日志文件
    /// </summary>
    /// <param name="robotIdx"></param>
    public static void DayResetLogFile()
    {
        if (!Directory.Exists("log"))
        {
            Directory.CreateDirectory("log");
        }
        _log_file_path = string.Format("./log/Robot_{0}_{1}_{2}.log", _robotbatch, _robotIdx, DateTime.Now.ToString("yyyyMMdd"));
    }

    #region 写入文件
    private static void CheckLogFile(string path)
    {
        //每次重新创建
        if (File.Exists(path))
        {
            System.IO.File.Delete(path);
        }
    }

    private static void CacheLog(string msg)
    {
        byte[] bs = System.Text.Encoding.UTF8.GetBytes(msg);

        // 如果缓存空间不足，立即刷新
        if (_cache_pool_size + bs.Length >= _cache_max_size)
        {
            FlushLog();
        }

        // 写入缓存空间
        if (_cache_pool_size + bs.Length < _cache_max_size)
        {
            Buffer.BlockCopy(bs, 0, _cache_pool, _cache_pool_size, bs.Length);
            _cache_pool_size += bs.Length;
        }
        else
        {
            Console.WriteLine("CacheLog cache size not enough.cache_size:" + _cache_max_size);
        }
    }

    // 刷新数据到文件
    public static void FlushLog()
    {
        if (!_is_inited)
        {
            return;
        }

        if (_cache_pool == null || _cache_pool_size <= 0)
        {
            return;
        }

        try
        {
            bool isFlush = false;
            // 超过最小时间间隔时刷新
            float interval = (float)(Utils.GetTimeStamp() - _last_flush_ts);
            if (interval >= GlobeVar.logFileFlushInterval * 1000)
            {
                isFlush = true;
            }
            // 缓存空间中字节数超过一定比率时刷新
            if (_cache_pool_size >= (_cache_max_size * GlobeVar.logFileFlushRate))
            {
                isFlush = true;
            }

            if (isFlush)
            {
                using (FileStream fs = new FileStream(_log_file_path, FileMode.Append, FileAccess.Write))
                {
                    fs.Write(_cache_pool, 0, _cache_pool_size);
                    fs.Flush();
                    _cache_pool_size = 0;
                    _last_flush_ts = Utils.GetTimeStamp();
                }
            }
        }
        catch (Exception ex)
        {
            _cache_pool_size = 0;
            Console.WriteLine("LogModule FlushLog error.");
            Console.WriteLine(ex);
        }
    }
    public static void Log(string message)
    {
        //控制台输出
        if (GlobeVar.m_IsEnableLogConsole)
        {
            Console.WriteLine(message);
        }

        // 写入文件
        if (GlobeVar.m_IsEnableLogFile)
        {
            CacheLog(FormatFileLog(LogType.Log, message, null));
        }
    }

    public static void LogFormat(string format, params object[] args)
    {
        Log(string.Format(format, args));
    }

    public static void LogWarning(string message)
    {
        //控制台输出
        if (GlobeVar.m_IsEnableLogConsole)
        {
            Console.WriteLine(message);
        }

        // 写入文件
        if (GlobeVar.m_IsEnableLogFile)
        {
            CacheLog(FormatFileLog(LogType.Warning, message, null));
        }
    }

    public static void LogWarningFormat(string format, params object[] args)
    {
        LogWarning(string.Format(format, args));
    }

    public static void LogError(string message)
    {
        //错误信息需要输出
        Console.WriteLine(message);
  
        CacheLog(FormatFileLog(LogType.Error, message, null));
    }

    public static void LogErrorFormat(string format, params object[] args)
    {
        LogError(string.Format(format, args));
    }

    public static void LogException(System.Exception e)
    {
        //错误信息需要输出

        Console.WriteLine(e.Message + "\n" + e.StackTrace);
        CacheLog(FormatFileLog(LogType.Error, e.Message, e.StackTrace));
    }

    public static void Assert(bool condition, string message)
    {
        //控制台输出
        if (GlobeVar.m_IsEnableLogConsole)
        {
            Console.WriteLine(message);
        }

        // 写入文件
        if (GlobeVar.m_IsEnableLogFile)
        {
            CacheLog(message);
        }
    }

    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        Assert(condition, string.Format(format, args));
    }
    private static string FormatFileLog(LogType type, string msg, string stackTrace)
    {
        string prefix = "[Log]";
        if (_logPrefix.ContainsKey(type))
        {
            prefix = _logPrefix[type];
        }

        StringBuilder sb = new StringBuilder();
        sb.Append(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]"));
        sb.Append(prefix);
        if (type == LogType.Log)
        {
            sb.AppendLine(msg);
        }
        else
        {
            sb.AppendLine(msg);
            sb.AppendLine(stackTrace);
        }
        return sb.ToString();
    }
    #endregion
}
