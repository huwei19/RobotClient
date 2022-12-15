using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_LOGIN_QUEUE_STATUS)]
public class GC_LOGIN_QUEUE_STATUS_Handler : MessageHandler<GC_LOGIN_QUEUE_STATUS>
{
    protected override void Execute(Robot curRobot, GC_LOGIN_QUEUE_STATUS message)
    {
        if (message.status == (int)ProtobufPacket.GC_LOGIN_QUEUE_STATUS.STATUS.UPDATE) {
            curRobot.mainPlayer.queuingIndex = message.index;
            curRobot.LoginState = (int)StateLogin.State.QUEUEING;
        } else if (message.status == (int)ProtobufPacket.GC_LOGIN_QUEUE_STATUS.STATUS.END) {
            curRobot.mainPlayer.queuingIndex = -1;
        }
    }
}
