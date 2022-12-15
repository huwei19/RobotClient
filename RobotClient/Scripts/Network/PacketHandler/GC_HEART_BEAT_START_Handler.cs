using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_HEART_BEAT_START)]
public class GC_HEART_BEAT_START_Handler : MessageHandler<GC_HEART_BEAT_START>
{
    protected override void Execute(Robot curRobot, GC_HEART_BEAT_START message)
    {
        
    }
}
