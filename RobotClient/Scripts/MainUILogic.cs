using System.Collections;
using GCGame.Table;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq.Expressions;
using ProtobufPacket;
using System;
using LiteNet;
using LitJson;
using System.Web;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

public class MainUILogic
{
    class AddRobotData
    {
        public AddRobotData(int serverID, int type, bool bSaveLog, int count,int forbidHttpType)
        {
            m_serverID = serverID;
            m_type = type;
            m_bSaveLog = bSaveLog;
            m_count = count;
            m_forbidHttpType = forbidHttpType;
        }

        public int m_serverID;
        public int m_type;
        public bool m_bSaveLog;
        public int m_count;
        public int m_forbidHttpType; //(禁止登陆模式：0无禁止，1禁止http登陆，2禁止https登陆)
    }

    private List<Robot> m_robotList = new List<Robot>();
    //public RobotLogWindow robotLogWindow;
    public bool IsUseSmallItem = true;

    private float m_fLastTickTime = 0;
    private float m_fLastUpdateTime = 0;

    private List<AddRobotData> m_robotAddList = new List<AddRobotData>();
    public int RobotSelfAddID
    {
        get { return m_robotSelfAddID; }
        set { m_robotSelfAddID = value; }
    }

    public List<Robot> RobotList { get { return m_robotList; } }

    private int m_robotSelfAddID = 1;

    private float m_addRobotTimer = 0;

    private int m_Interval = 1000;

    public int Interval { get { return m_Interval; } }

    private int m_RestartInterval = 10000;
    public int RestartInterval { get { return m_RestartInterval; } set { m_RestartInterval = value; } }

    private float m_CheckValidInterval = 5;
    private float m_LastCheckValidTime = -1.0f;

    //第N批次机器人
    private int robotIdx = 0;
    //命令批次
    private int robotbatch = 0;

    private static MainUILogic m_instance = new MainUILogic();
    public static MainUILogic Instance()
    {
        return m_instance;
    }

    public void Start()
    {
        GlobalData.InitServerListData();
        LiteNet.Network.Init();
    }

    public void Update()
    {
        float curTime = (float)Utils.GetTimeStamp();
        m_fLastTickTime = m_fLastUpdateTime > 0 ? curTime - m_fLastUpdateTime : 0;
        m_fLastUpdateTime = curTime;

        List<Robot> invalidRobots = new List<Robot>();
        for (int idx = 0; idx < m_robotList.Count; ++idx)
        {
            Robot robot = m_robotList[idx];
            if (!robot.m_IsValid)
            {
                invalidRobots.Add(robot);
                continue;
            }
            //这里就是 持续执行 各个业务State的onExecute周期 比如 StateDrawCard.onExecute
            m_robotList[idx].Update();
        }
        if (curTime - m_LastCheckValidTime >= m_CheckValidInterval)
        {
            if (invalidRobots.Count > 0)
            {
                for (int idx = 0; idx < invalidRobots.Count; idx++)
                {
                    Robot robot = invalidRobots[idx];
                    if (robot != null)
                    {
                        //GameLog.Log("--- remove 1 robot: " + robot.Name);
                        RemoveRobot(robot);
                    }
                }
            }
            m_LastCheckValidTime = curTime;
        }

        if (m_robotAddList.Count > 0)
        {
            m_addRobotTimer -= ParamTime.deltaTime;
            if (m_addRobotTimer < 0)
            {
                AddRobotData curData = m_robotAddList[0];
                if (m_robotAddList[0].m_count > 0)
                {
                    m_robotAddList[0].m_count--;
                    Robot robot1 = new Robot();
                    m_robotList.Add(robot1);
                    string robotName = CreateRobotName();
                    //GameLog.Log("--- add 1 robot:" + robotName);
                    robot1.Start(robotName, m_robotAddList[0].m_serverID, m_robotAddList[0].m_bSaveLog, m_robotAddList[0].m_type, m_robotSelfAddID, m_robotAddList[0].m_forbidHttpType);
                    //robotListWindow.AddRobot(robot1, IsUseSmallItem);
                    m_robotSelfAddID++;
                }

                if (m_robotAddList[0].m_count <= 0)
                {
                    //GameLog.Log("--- 剔除了一个机器人工厂, serverID:" + m_robotAddList[0].m_serverID + " #robotType:" + (Robot.RobotType)m_robotAddList[0].m_type + " #count:" + m_robotAddList[0].m_count);
                    m_robotAddList.RemoveAt(0);
                }
                m_addRobotTimer = 0.2f;
            }
        }

        //跨天检查
        CheckDay();

        //记录日志
        GameLog.FlushLog();
    }

    //上次记录的天 yyyyMMdd
    private string s_LastDay = "";

    /// <summary>
    /// 跨天检查
    /// </summary>
    public void CheckDay()
    {
        string nowDay = DateTime.Now.ToString("yyyyMMdd");
        if (s_LastDay != nowDay)
        {
            //跨天重新 设置新的日志文件名称
            GameLog.DayResetLogFile();
            s_LastDay = nowDay;
        }
    }

    private void RemoveRobot(Robot robot)
    {
        robot.LogError(" ---- RemoveRobot --- " + robot.Name);
        robot.Shut();
        m_robotList.Remove(robot);
    }

    void OnDestroy()
    {
        foreach (Robot robot in m_robotList)
        {
            robot.LogError(" ---- OnDestroy --- " + robot.Name);
            robot.Shut();
        }
    }

    /////////////////////////////////////////////////////////////////
    public void AddRobot(int count, int serverID, bool bSaveLog, int robotType,int forbidHttpType)
    {
        AddRobotData curData = new AddRobotData(serverID, robotType, bSaveLog, count, forbidHttpType);
        //GameLog.Log("--- 增加了一个机器人工厂, serverID:" + serverID + " #robotType:" + (Robot.RobotType)robotType + " #bSaveLog:" + bSaveLog + " #count:" + count);
        m_robotAddList.Add(curData);
    }

    public void SendCmdRange(int startID, int endID, string cmd)
    {
        foreach (Robot curRobo in m_robotList)
        {
            if (curRobo.RobotID >= startID && curRobo.RobotID <= endID)
            {
                curRobo.SendCMD(cmd);
            }
        }
    }

    public void StopAllRobots()
    {
        foreach (Robot robot in m_robotList)
        {
            robot.FSM.ChangeState(new StateHalt());
        }
        GameLog.Log("stop all robots");
    }

    public float LastTickTime()
    {
        return m_fLastTickTime;
    }
    private string CreateRobotName()
    {
        string robotId = num_to_str_XXX(m_robotSelfAddID);
        return string.Format("r{0}-{1}-{2}",robotbatch, robotIdx, robotId);
    }

    private string num_to_str_XXX(int val)
    {
        if (val == 0) return "";
        if (val < 1000) return val.ToString();

        int last_xxx = val % 10;
        int begin_x = val / 10;

        string[] one_char = { "零", "一", "二", "三", "四", "五", "六", "七", "八", "九" };

        return num_to_str_XXX(begin_x) + one_char[last_xxx];
    }


    #region 参数启动
    public IEnumerator StartByCommand(bool isTest = false)
    {
        GameLog.LogFormat("------- 开始 StartByCommand ----");
        string s_batch = "0";
        string s_robotIdx = "601";
        string aiType = "0";
        string robotNum = "0";
        string serverId = "100";
        string isLog = "true";
        string initId = "1";
        string ExeCDTime = "1";
        string arg0 = "1000";
        string arg1 = "5";
        string arg2 = "0";

        if (isTest)
        {
            s_robotIdx = "601";
            aiType = "0";
            robotNum = "0";
            serverId = "100";
            isLog = "true";
            initId = "1";
            ExeCDTime = "1";
            arg0 = "1000";
            arg1 = "5";
            arg2 = "0";
        }
        else
        {
            var args = System.Environment.GetCommandLineArgs();
            if (args.Length < 9)
            {
                yield break;
            }
            s_batch = GetArg("-batch");
            s_robotIdx = GetArg("-robotIdx");
            aiType = GetArg("-aiType");
            robotNum = GetArg("-robotNum");
            serverId = GetArg("-serverId");
            isLog = GetArg("-isLog").Trim().ToLower();
            initId = GetArg("-initId");
            ExeCDTime = GetArg("-ExeCDTime");
            arg0 = GetArg("-arg0");
            arg1 = GetArg("-arg1");
            arg2 = GetArg("-arg2");
        }

        int m_robotNum = int.Parse(robotNum);
        int m_serverId = int.Parse(serverId);
        int m_aiType = int.Parse(aiType);
        bool m_isLog = bool.Parse(isLog);
        robotIdx = int.Parse(s_robotIdx);
        robotbatch = int.Parse(s_batch);
        int forbidHttpType = int.Parse(arg0);

        //注册日志事件
        GameLog.RegisterLog(robotbatch,robotIdx);

        //添加机器人工厂
        AddRobot(m_robotNum, m_serverId, m_isLog, m_aiType, forbidHttpType);

        GameLog.LogFormat("------- 结束 StartByCommand ----");
    }

    private static string GetArg(string name)
    {
        var args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == name && args.Length > i + 1)
            {
                return args[i + 1];
            }
        }
        return null;
    }
    #endregion

    #region 大区登录

    /// <summary>
    /// 尝试链接服务器 开启协程
    /// </summary>
    /// <param name="url"></param>
    /// <param name="callback"></param>
    public MyServerInfoJson GetServerInfo(string url)
    {
        HttpClientHelper httpClientHelper = new HttpClientHelper();
        Task<string> resultTask = httpClientHelper.GetAsync(url); //异步执行
        string result = resultTask.Result; //---------->这里会等待Task返回 才会执行后面的操作
        if (result != null)
        {
            MyServerJson serverJson = JsonMapper.ToObject<MyServerJson>(result);
            if (serverJson == null)
            {
                return null;
            }

            if (serverJson.code != 1 || serverJson.info == null)
            {
                GameLog.LogErrorFormat("-------- server info error: {0} - {1}", serverJson.code, serverJson.info);
                return null;
            }
            return serverJson.info;
        }
        return null;
    }
    #endregion
}
