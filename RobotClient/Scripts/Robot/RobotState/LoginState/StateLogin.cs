using System.Collections;
using GCGame.Table;
using ProtobufPacket;
using LiteNet;
using Games.GlobeDefine;

public class StateLogin : FSMState<Robot>
{
    public enum State
    {
        NONE,
        SUCCESS,
        CREATEUSER,
        FAIL,
        QUEUEING,
    }

    public override string getName()
    {
        return "Login";
    }

    public override void onEnter(Robot entity)
    {
        //HG_VALIDATE_ACCOUNT_RET packet2 = new HG_VALIDATE_ACCOUNT_RET();
        entity.Log("开始执行: login onEnter ");
        entity.Log("try login");
        entity.LoginState = (int)State.NONE;

        CG_LOGIN packet = new CG_LOGIN();
        packet.logintype = (int)CG_LOGIN.LOGINTYPE.TEST;
        packet.gameversion = GlobeVar.m_GameVersion;
        packet.programversion = GlobeVar.m_ProgramVersion;
        packet.forceenter = true;
        packet.maxpacketid = (int)MessageID.Max;
        packet.accountname = entity.Name;

        packet.token = "";
        packet.mediaid = 0;
        packet.phonemodel = "PC";
        packet.MemorySize = 0;
        packet.uuid = "";

        packet.msdk = new global::ProtobufPacket._MSDK();
        packet.msdk.platform = "1";

        //关键登陆字段 判定账号为机器人 bios、bimac、logintype
        packet.bios = (int)CG_LOGIN.BIOSTYPE.IOSJB;
        packet.bimac = "Robot";
        packet.logintype = (int)CG_LOGIN.LOGINTYPE.TEST;

        packet.rapidvalidatecode = entity.mainPlayer.rapidvalidatecode;
        packet.autoselectroleguid = entity.mainPlayer.playerGuid_;

        packet.resversion = 0;
        //entity.NetManager.SendMsg(packet);

        entity.Log("---------------发送了一个login消息包");
        entity.SendMsg(packet);
        //初始化状态
        entity.GameState = (int)StateEnterGame.State.NONE;

        entity.TransStart(TransEvent.Login);
    }

    public override void onExecute(Robot entity)
    {
        switch ((State)entity.LoginState)
        {
            case State.SUCCESS:
                entity.FSM.ChangeState(new StateEnterGame());
                break;
            case State.CREATEUSER:
                entity.FSM.ChangeState(new StateCreateUser());
                break;
            case State.QUEUEING:
                entity.Log("login queue " + entity.mainPlayer.queuingIndex);
                entity.IsQueuing = true;
                break;
            case State.FAIL:
                entity.Log("login fail");
                entity.FSM.ChangeState(new StateExit());
                break;
        }

        entity.Log("执行: login onExecute ;并且LoginState为 " + (State)entity.LoginState);
        return;
    }
}

