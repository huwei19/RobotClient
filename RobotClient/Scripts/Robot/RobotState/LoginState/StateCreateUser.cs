/********************************************************************
	purpose:	创建角色状态
*********************************************************************/
using System;
using ProtobufPacket;
public class StateCreateUser : FSMState<Robot>
{
    public enum State
    {
        NONE,
        SUCCESS,
        FAIL,
        NAMEREPEAT,
    }

    public override string getName()
    {
        return "Create User";
    }

    public override void onEnter(Robot entity)
    {
        entity.Log("creating user");
        entity.LoginState = (int)State.NONE;
        entity.IsQueuing = false;

        CG_CREATE_USER packet = new CG_CREATE_USER();

        //是好友
        Random r = new Random();
        //0 到 Robot.m_FriendCreatUserName.Length 之间
        int i = r.Next(Robot.m_FriendCreatUserName.Length);
        entity.Log("角色名称 " + Robot.m_FriendCreatUserName[i]);
        packet.name = Robot.m_FriendCreatUserName[i];
        packet.sex = 0;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        entity.TransStart(TransEvent.CreateRole);
    }

    public override void onExecute(Robot entity)
    {
        switch ((State)entity.LoginState)
        {
            case State.SUCCESS:
                entity.Log("create user success");
                entity.FSM.ChangeState(new StateEnterGame());
                break;
            case State.FAIL:
                entity.Log("creating user fail " + entity.LoginRet);
                entity.FSM.ChangeState(new StateExit());
                break;
            case State.NAMEREPEAT:
                entity.Log("creating user fail, name repeated");
                entity.FSM.ChangeState(new StateExit());
                break;
        }
        return;
    }


}
