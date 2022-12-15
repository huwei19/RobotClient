using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_LOGIN_RET)]
public class GC_LOGIN_RET_Handler : MessageHandler<GC_LOGIN_RET>
{
    protected override void Execute(Robot curRobot, GC_LOGIN_RET message)
    {
        if (message.result == RESULT.SUCCESS) {
            curRobot.mainPlayer.rapidvalidatecode = message.rapidvalidatecode;
            curRobot.mainPlayer.lastRapidCode = message.rapidvalidatecode;
            curRobot.LoginState = (int)StateLogin.State.SUCCESS;
            curRobot.TransEnd(TransEvent.Login, message.result);
        } else if (message.result == RESULT.CREATE_USER) {
            curRobot.mainPlayer.rapidvalidatecode = message.rapidvalidatecode;
            curRobot.mainPlayer.lastRapidCode = message.rapidvalidatecode;
            curRobot.LoginState = (int)StateLogin.State.CREATEUSER;
            curRobot.TransEnd(TransEvent.Login, RESULT.SUCCESS);
        } else {
            curRobot.LogError("login fail,result: " + message.result+ " processfailcode: " + message.Has_validateprocessfailcode);
            curRobot.LoginState = (int)StateLogin.State.FAIL;
            curRobot.TransEnd(TransEvent.Login, message.result);
        }
    }
}
