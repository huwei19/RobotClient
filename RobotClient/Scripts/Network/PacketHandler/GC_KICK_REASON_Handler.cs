using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_KICK_REASON)]
public class GC_KICK_REASON_Handler : MessageHandler<GC_KICK_REASON>
{
    protected override void Execute(Robot curRobot, GC_KICK_REASON message)
    {
        
    }
}
