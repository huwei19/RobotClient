using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_HEART_BEAT)]
public class GC_HEART_BEAT_Handler : MessageHandler<GC_HEART_BEAT>
{
    protected override void Execute(Robot curRobot, GC_HEART_BEAT message)
    {
        
    }
}
