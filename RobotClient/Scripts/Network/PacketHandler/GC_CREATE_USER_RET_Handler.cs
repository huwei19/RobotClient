using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CREATE_USER_RET)]
public class GC_CREATE_USER_RET_Handler : MessageHandler<GC_CREATE_USER_RET>
{
    protected override void Execute(Robot curRobot, GC_CREATE_USER_RET message)
    {
        curRobot.TransEnd(TransEvent.CreateRole, message.result);
        if (message.result == RESULT.SUCCESS) {
            curRobot.LoginState = (int)StateCreateUser.State.SUCCESS;
        } else if (message.result == RESULT.CREATE_USER_FAIL_NAMEEXIST){
            curRobot.LoginState = (int)StateCreateUser.State.NAMEREPEAT;
            curRobot.LoginRet = message.result;
        } else {
            curRobot.LoginState = (int)StateCreateUser.State.FAIL;
            curRobot.LoginRet = message.result;
        }
    }
}
