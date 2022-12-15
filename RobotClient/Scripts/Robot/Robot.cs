using UnityEngine;
using System.Collections;
using System.Threading;
using System.Text;
using GCGame.Table;
using System;
using System.Collections.Generic;
using Games.Table;
//using NUnit.Framework;
using LiteNet;

public partial class Robot
{
    public enum RobotType
    {
        //功能相关压测脚本
        TYPE_SCENE_MAIN = 0, //只进入，什么操作都不做
        //TYPE_RELOGIN,//重复登录
        TYPE_CHAPTER = 1,//章节（主线/暗线）
        TYPE_RUMOR = 2,//传闻调查
        TYPE_STORY = 3,//故事
        TYPE_CITY = 4,//城市
        TYPE_REWIND = 5,//时间回溯
        TYPE_SHOP = 6,//商铺
        TYPE_DRAWCARD = 7,//抽卡
        TYPE_ITEM = 8,//物品
        TYPE_CARD = 9,//卡牌
        TYPE_TASK = 10,//任务
        TYPE_MAIL = 11,//邮件
        TYPE_FRIEND = 12,//好友
        TYPE_DRESSUP = 13,//时装
        TYPE_STORY_EX = 14, //自动调查
        TYPE_FRIEND_GIVE = 15, //好友赠领

        //数据相关压测脚本
        TYPE_RANDOMCG = 16,
        TYPE_RANDOMMSG = 17,
        TYPE_RANDOMBYTE = 18,

        TYPE_HALT = 19,     //停止

        TYPE_NONE = -1,
    };

    //(禁止登陆模式：0无禁止，1禁止http登陆，2禁止https登陆)
    public enum ForbidHttpType
    {
        ForbidNone = 0,
        ForbidHttp = 1,
        ForbidHttps = 2,
    }


    public bool IsRunning = false;
    public bool IsConnected = false;
    public bool IsQueuing = false;

    public string Name { set; get; }
    public NetworkLogic NetManager { get { return m_networkLogic; } }

    /// <summary>
    /// 每个机器人 对应的状态机
    /// </summary>
    /// <value></value>
    public FSMMachine<Robot> FSM { get { return m_fsm; } }

    public int LoginState { set; get; }

    public int CardState { set; get; }

    public ProtobufPacket.RESULT LoginRet { set; get; }
    public int GameState { set; get; }
    public int RobotID { set; get; }
    public LoginData loginData = new LoginData();
    public int IPListID = 16;
    public bool IsLogSave = false;
    public RobotType BehaviorType = RobotType.TYPE_CHAPTER;

    public bool UseLoginServer { set; get; }

    /// <summary>
    /// 每个机器人 对应的服务器ip 信息
    /// </summary>
    /// <value></value>
    public MyServerInfoJson ServerInfo { set; get; }

    private Thread m_hConnectThread = null;
    private NetworkLogic m_networkLogic;
    private FSMMachine<Robot> m_fsm;
    private StringBuilder m_logString = new StringBuilder();
    private RobotAIBase m_curAI;

    public bool m_IsValid = true;

    public bool IsInScene = false;
    private float m_heartBeatTimer = 0;

    /// 卡牌升级需要存储的卡牌id
    /// 
    public int m_statcard_id = 0;
    public int m_statcard_lv = 1;
    public int m_statcard_exp = 0;
    public int m_statcard_star = 0;
    public Dictionary<int, bool> m_can_star_level_up = new Dictionary<int, bool>();

    public int m_statcard_make_id = 2;
    public int m_statcard_make_finish = 0;

    public int m_statcard_resolve_id = 4;
    public int m_statcard_resolve_finish = 0;

    public int m_statcard_visual_id = 11;
    public int m_statcard_visual_finish = 0;

    public int m_statcard_fileunlock_id = 5;
    public List<bool> m_statcard_fileunlock_finish = new List<bool>();

    public int m_statcard_fileaward_id = 0;
    public List<bool> m_statcard_fileaward_finish = new List<bool>();

    public int m_statcard_enhance_id = 0;
    public int m_statcard_enhance_finish = 0;
    /// <summary>
    /// 卡牌 能力强化 次数
    /// </summary>
    public int m_statcard_abilityup_finish = 0;
    /// <summary>
    /// 卡牌 培训次数
    /// </summary>
    public int m_statcard_trainlevel_finish = 0;

    public int m_statcard_changeface_id = 0;
    public int m_statcard_changeface_finish = 0;

    /// 抽卡
    /// 
    public int m_statdrawcard_advance_count = 0;

    /// 城市相关 (登陆会同步 GC_SYNC_CITYWORK_Handler)
    /// 
    public Dictionary<int/*任务id*/, Dictionary<int/*城市id*/, List<int/*卡牌id*/>>> tempCityWorkTask = new Dictionary<int, Dictionary<int, List<int>>>();
    public Dictionary<int/*任务id*/, int/*城市id*/> tempCityWorkTaskAward = new Dictionary<int, int>();
    public int cityTaskId = 0;


    /// 命运线换装
    /// 
    public Dictionary<int/*skinid*/, Tab_SkinData> skindId = new Dictionary<int/*skinid*/, Tab_SkinData>();
    public Dictionary<int/*dressid*/, Tab_Dressup> dressId = new Dictionary<int/*skinid*/, Tab_Dressup>();

    /// 好友
    /// 
    /// <summary>
    /// 好友列表名称-uid 的字典 ; 关键字static ；说明10个机器人就能搜索到的可能10个好友
    /// </summary>
    /// <typeparam name="string"></typeparam>
    /// <typeparam name="ulong"></typeparam>
    /// <returns></returns>
    public static Dictionary<string, ulong> m_search = new Dictionary<string, ulong>();
    public int m_frend_add_pos = 0;
    public Dictionary<long, int> m_apply = new Dictionary<long, int>();
    public Dictionary<long, string> m_friend = new Dictionary<long, string>();
    public static string[] m_FriendCreatUserName = { "机器RF0", "机器RF1", "机器RF2", "机器RF3", "机器RF4", "机器RF5", "机器RF6", "机器RF7", "机器RF8", "机器RF9", };


    /// 邮件
    /// 
    public List<ulong> m_mail = new List<ulong>();

    /// 任务列表
    /// 
    public List<global::ProtobufPacket._TaskData> m_task = null;

    //http模式
    //当前机器人登陆模式(大区会有 http和https，单服只会有http )
    public ForbidHttpType m_forbidHttpType = ForbidHttpType.ForbidNone;
    public GlobalData.HttpType httpType = GlobalData.HttpType.Http;
    public int m_failCountHttp = 0;
    public int m_failCountHttps = 0;
    //http模式

    public void Start(string name, int serverID, bool bSaveLog, int type, int robotID, int forbidHttpType)
    {
        IsRunning = true;
        IsConnected = false;
        IsQueuing = false;
        ServerInfo = null;

        Name = name;

        IPListID = serverID;
        IsLogSave = bSaveLog;
        BehaviorType = (Robot.RobotType)type;
        if (null != m_hConnectThread)
        {
            m_hConnectThread.Abort();
        }
        RobotID = robotID;

        //设置机器人 禁止登陆模式
        if (forbidHttpType == 1)
        {
            m_forbidHttpType = ForbidHttpType.ForbidHttp;
        }
        else if (forbidHttpType == 2)
        {
            m_forbidHttpType = ForbidHttpType.ForbidHttps;
        }
        else
        {
            m_forbidHttpType = ForbidHttpType.ForbidNone;
        }
        ResetHttpFailCount();

        m_networkLogic = new NetworkLogic(this);
        m_fsm = new FSMMachine<Robot>(this);

        GlobalData.ServerListData sdata = GlobalData.s_ServerList.Find(t => t.serverID == IPListID);
        if (sdata != null)
        {
            if (sdata.regionID > 0) //大区模式登陆
            {
                UseLoginServer = true;
                m_fsm.ChangeState(new StateConnectLoginServer());
            }
            else  //单服模式登陆
            {
                UseLoginServer = false;
                m_fsm.ChangeState(new StateConnectServer());
            }
        }
        else
        {
            LogError("Robot Start server id not exist: " + IPListID);
            m_fsm.ChangeState(new StateHalt());
        }
    }

    public void Shut()
    {
        IsInScene = false;
        IsRunning = false;
        IsConnected = false;
        IsQueuing = false;

        LogError("---robot Shut--- " + Name);
        m_networkLogic.Release();
        if (null != m_hConnectThread)
        {
            m_hConnectThread.Abort();
        }
    }

    public void Reconnect()
    {
        LogError("---重连 robot Reconnect 进入LoginServerState --- " + Name);
        IsRunning = true;
        IsConnected = false;
        if (UseLoginServer)
        {
            m_fsm.ChangeState(new StateConnectLoginServer());
        }
        else
        {
            m_fsm.ChangeState(new StateConnectServer());
        }
    }

    public void Update()
    {
        m_networkLogic.Update(); //---> 第一个服务器消息包处理 OnSession handle回调
        m_fsm.Update();
    }

    #region Log写入接口
    public void Log(string message)
    {
        if (IsLogSave)
            GameLog.Log("[Robot:" + Name + "] " + message);
        if (IsLogSave)
        {
            m_logString.AppendLine(message);
        }
    }

    public void LogFormat(string format, params object[] args)
    {
        Log(string.Format(format, args));
    }

    public void LogWarning(string message)
    {
        if (IsLogSave)
            GameLog.LogWarning("[Robot:" + Name + "] " + message);
        if (IsLogSave)
        {
            m_logString.AppendLine(message);
        }
    }

    public void LogWarningFormat(string format, params object[] args)
    {
        LogWarning(string.Format(format, args));
    }

    public void LogError(string message)
    {
        GameLog.LogError("[Robot:" + Name + "] " + message);
        m_logString.AppendLine(message);
    }

    public void LogErrorFormat(string format, params object[] args)
    {
        LogError(string.Format(format, args));
    }

    public void LogException(System.Exception e)
    {
        Debug.LogException(e);
        if (IsLogSave)
        {
            m_logString.AppendLine(e.Message + "\n" + e.StackTrace);
        }
    }

    public void Assert(bool condition, string message)
    {
        if (IsLogSave)
            GameLog.Assert(condition, "[Robot:" + Name + "] " + message);
        if (IsLogSave)
        {
            m_logString.AppendLine(message);
        }
    }

    public void AssertFormat(bool condition, string format, params object[] args)
    {
        Assert(condition, string.Format(format, args));
    }
    #endregion

    public string GetLogString()
    {
        return m_logString.ToString();
    }

    public void LogGameState(string str)
    {

    }

    public void SetAI(RobotAIBase curAI)
    {
        m_curAI = curAI;
    }

    public RobotAIBase GetAI()
    {
        return m_curAI;
    }

    public void UpdateAI()
    {
        if (null != m_curAI) m_curAI.update();
    }

    public void SendMsg(IMessage message)
    {
        MessageID messageId = MessageMapping.GetMessageID(message.GetType());
        StatisticsData.StatisticsSend(RobotID, messageId);
        NetManager.SendMsg(message);
    }

    //再serverlist 寻找 http模式，如果找不到就将 m_failCount置为999
    public void ResetHttpFailCount()
    {
        //m_failCountHttp、m_failCountHttps
        //尝试获取 找寻一个 http或者https模式 即可
        GlobalData.ServerListData sdata_http = GlobalData.s_ServerList.Find(t => t.serverID == IPListID && t.httpType == GlobalData.HttpType.Http);
        if (sdata_http == null || m_forbidHttpType == ForbidHttpType.ForbidHttp)
        {
            m_failCountHttp = 999;
        }
        //尝试获取 找寻一个 http或者https模式 即可
        GlobalData.ServerListData sdata_https = GlobalData.s_ServerList.Find(t => t.serverID == IPListID && t.httpType == GlobalData.HttpType.Https);
        if (sdata_https == null || m_forbidHttpType == ForbidHttpType.ForbidHttps)
        {
            m_failCountHttps = 999;
        }
    }
}
