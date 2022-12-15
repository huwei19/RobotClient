using UnityEngine;
using System.Collections;
using GCGame.Table;

public class StateReconnectServer : FSMState<Robot> 
{

    private bool m_bConnectFinish = false;
    private bool m_bConnectSuccess = false;

    public override void onEnter(Robot entity)
    {
        entity.IsInScene = false;
        entity.Log("connecting server..");
        m_bConnectFinish = false;
    }

    public override void onExecute(Robot entity)
    {
        if (m_bConnectFinish)
        {
            if (m_bConnectSuccess)
            {
                entity.Log(": re connect server success");
                entity.FSM.ChangeState(new StateLogin());
            }
            else
            {
                entity.Log(": re connect server fail");
                entity.FSM.ChangeState(new StateExit());

            }
        }
        base.onExecute(entity);
        return;
    }

    public override string getName()
    {
        return "Connect Server";
    }

    void OnConnectServer(bool bSuccess, string result)
    {
        m_bConnectFinish = true;
        m_bConnectSuccess = bSuccess;

    }
}
