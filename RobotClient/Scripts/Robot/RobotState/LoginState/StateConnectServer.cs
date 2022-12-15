/********************************************************************
	purpose:	连接服务器状态
*********************************************************************/

using UnityEngine;
using System.Collections.Generic;
using GCGame.Table;

public class StateConnectServer : FSMState<Robot>
{
    private bool m_bConnectFinish = false;
    private bool m_bConnectSuccess = false;

    public override void onEnter(Robot entity)
    {
        entity.IsInScene = false;
        m_bConnectFinish = false;
        m_bConnectSuccess = false;

        bool exit = true;
        if (entity.UseLoginServer)
        {
            if (entity.ServerInfo != null)
            {
                int port = 0;
                if (int.TryParse(entity.ServerInfo.port, out port))
                {
                    entity.NetManager.onConnectServer = OnConnectServer;
                    entity.NetManager.Connect(entity.ServerInfo.ip, port);
                    exit = false;
                }
            }
        }
        else
        {
            //entity.Log("---查找服务器列表entity.IPListID： " + entity.IPListID);
            GlobalData.ServerListData sdata = GlobalData.s_ServerList.Find(t => t.serverID == entity.IPListID && t.httpType == GlobalData.HttpType.Http);
            if (sdata!=null)
            {
                entity.NetManager.onConnectServer = OnConnectServer;
                //entity.Log("开始链接---sdata.ip:" + sdata.ip + " #sdata.port:" + sdata.port);
                entity.LogFormat("connecting server {0}:{1}", sdata.ip, sdata.port);
                entity.NetManager.Connect(sdata.ip, sdata.port);
                exit = false;
            }
        }

        if (exit)
        {
            entity.Log("serverid donot exist" + entity.IPListID);
            entity.FSM.ChangeState(new StateExit());
        }
    }

    public override void onExecute(Robot entity)
    {
        if (m_bConnectFinish)
        {
            if (m_bConnectSuccess)
            {
                entity.Log(": connect server success");
                entity.FSM.ChangeState(new StateLogin());
            }
            else
            {
                entity.LogError(": connect server fail");
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
        return string.Format("Connect Server finish:{0}, success:{1}", m_bConnectFinish, m_bConnectSuccess);
    }

    void OnConnectServer(bool bSuccess)
    {
        m_bConnectFinish = true;
        m_bConnectSuccess = bSuccess;
    }
}
