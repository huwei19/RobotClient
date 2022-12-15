/********************************************************************
	purpose:	连接服务器状态  loginServer方式登陆服务器
*********************************************************************/

using System.Collections.Generic;
using GCGame.Table;
using Games.GlobeDefine;
using System;
using System.Threading.Tasks;

/// <summary>
/// www返回text的 序列化格式
/// </summary>
public class MyServerJson
{
    public int code;
    public string error;
    public MyServerInfoJson info;
}

public class MyServerInfoJson
{
    public string srvid;
    public string region;
    public string online;
    public string queue;
    public string ttlReg;
    public string openReg;
    public string updateTime;
    public string ip;
    public string ipv6;
    public string port;
}

public class StateConnectLoginServer : FSMState<Robot>
{
    private bool m_bConnectFinish = false;
    private MyServerInfoJson m_serverInfo = null;

    public GlobalData.ServerListData GetCurrServerListData(Robot entity)
    {
        GlobalData.ServerListData sdata = null;
        switch (entity.m_forbidHttpType)
        {
            case Robot.ForbidHttpType.ForbidNone:
                {
                    break;
                }
            case Robot.ForbidHttpType.ForbidHttp:
                {
                    if (entity.httpType == GlobalData.HttpType.Http)
                    {
                        entity.httpType = GlobalData.HttpType.Https;
                    }
                    break;
                }
            case Robot.ForbidHttpType.ForbidHttps:
                {
                    if (entity.httpType == GlobalData.HttpType.Https)
                    {
                        entity.httpType = GlobalData.HttpType.Http;
                    }
                    break;
                }
            default:
                {
                    break;
                }
        }

        //找寻当前http模式
        sdata = GlobalData.s_ServerList.Find(t => t.serverID == entity.IPListID && t.httpType == entity.httpType);
        return sdata;
    }

    public override void onEnter(Robot entity)
    {
        entity.IsInScene = false;
        m_bConnectFinish = false;
        entity.ServerInfo = null;
        string salt = new Random().Next(0, 65535).ToString();
        string szSign = entity.Name + GlobeVar.RedisSecurityKey + salt;
        szSign = Utils.GetStringMD5(szSign).ToLower();

        bool exit = true;

        //寻找符合条件的 登陆服
        GlobalData.ServerListData sdata = GetCurrServerListData(entity);
        if (sdata != null)
        {
            //优先http
            string url = string.Format(GlobeVar.LoginSvrUrlHttp, sdata.ip, sdata.port);
            if (sdata.httpType == GlobalData.HttpType.Https)
            {
                url = string.Format(GlobeVar.LoginSvrUrlHttps, sdata.ip, sdata.port);
            }

            string urlparam = string.Format(GlobeVar.PostRefix_RegionLogin, entity.Name, sdata.regionID, salt, szSign);
            string furl = url + urlparam;
            entity.Log("---海外服务器地址:" + furl);

            //更新entity的 当前http模式
            entity.httpType = sdata.httpType;

            //开启新线程 异步获取服务器地址 --------> 得到服务器地址后的 OnGetServerInfo 回调
            new Task(() =>
            {
                //GameLog.Log("---开起了新线程任务： 准备从loginServer获得服务器地址:" + furl);
                MyServerInfoJson m_MyServerInfoJson = MainUILogic.Instance().GetServerInfo(furl);
                OnGetServerInfo(entity, m_MyServerInfoJson);
                //GameLog.Log("--- 结束新线程任务");
            }).Start();

            exit = false;
        }

        //没有找到配置信息就 进入到 StateExit 状态
        if (exit)
        {
            entity.Log("onEnter server id not exist: " + entity.IPListID);
            entity.FSM.ChangeState(new StateHalt());
        }
    }

    public override void onExecute(Robot entity)
    {
        //m_bConnectFinish 标识位 成功，说明已成功链接上； -----------> onEnter函数里面的 OnGetServerInfo回调
        if (m_bConnectFinish)
        {
            entity.ServerInfo = m_serverInfo;
            if (entity.ServerInfo != null)
            {
                entity.Log(": connect login server success");
                entity.FSM.ChangeState(new StateConnectServer());
            }
            else
            {
                entity.Log(": connect login server fail");
                entity.FSM.ChangeState(new StateExit());

            }
        }
        base.onExecute(entity);
        return;
    }

    public override void onExit(Robot entity)
    {

    }

    public override string getName()
    {
        return string.Format("Connect Server finish:{0}, success:{1}", m_bConnectFinish, m_serverInfo != null);
    }

    /// <summary>
    /// 连接到serverInfo数据 回调
    /// </summary>
    /// <param name="sinfo"></param>
    void OnGetServerInfo(Robot entity, MyServerInfoJson sinfo)
    {
        if (sinfo == null)
        {
            //尝试重新获取
            entity.LogError("尝试获取不到serverInfo，大区id:" + entity.IPListID + " 类型httpType:" + entity.httpType.ToString() + ", m_failCountHttp:" + entity.m_failCountHttp + "  ,m_failCountHttps:" + entity.m_failCountHttps);

            //获取失败次数3次以上  切换entity的 当前http模式
            switch (entity.httpType)
            {
                case GlobalData.HttpType.Http:
                    {
                        entity.m_failCountHttp++;

                        //http失败三次以上 切换模式
                        if (entity.m_failCountHttp >= GlobeVar.MAX_HTTP_FAILCOUNT)
                        {
                            entity.httpType = GlobalData.HttpType.Https;
                        }

                        break;
                    }
                case GlobalData.HttpType.Https:
                    {
                        entity.m_failCountHttps++;

                        //https失败三次以上 切换模式
                        if (entity.m_failCountHttps >= GlobeVar.MAX_HTTP_FAILCOUNT)
                        {
                            entity.httpType = GlobalData.HttpType.Http;
                        }
                        break;
                    }
            }

            //http、https全都失败三次以上，进入StateHalt, 否则走重连
            if (entity.m_failCountHttp >= GlobeVar.MAX_HTTP_FAILCOUNT && entity.m_failCountHttps >= GlobeVar.MAX_HTTP_FAILCOUNT)
            {
                //http、https全部失败三次以上
                entity.LogError("获取不到serverInfo，大区id:" + entity.IPListID + ", m_failCountHttp:" + entity.m_failCountHttp + "  ,m_failCountHttps:" + entity.m_failCountHttps);
                entity.FSM.ChangeState(new StateHalt());
            }
            else
            {
                entity.FSM.ChangeState(new StateExit());
            }
        }
        else
        {
            //将 链接成功标识位 置为true
            m_bConnectFinish = true;

            //www 返回的login 结构数据
            m_serverInfo = sinfo;
        }
    }
}
