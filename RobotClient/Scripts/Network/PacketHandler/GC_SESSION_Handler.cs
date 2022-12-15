using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SESSION)]
public class GC_SESSION_Handler : MessageHandler<GC_SESSION>
{
    protected override void Execute(Robot curRobot, GC_SESSION message)
    {
        curRobot.NetManager.OnSession(message.session);
    }
}
