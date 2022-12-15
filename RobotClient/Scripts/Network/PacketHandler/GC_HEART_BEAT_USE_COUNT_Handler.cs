using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_HEART_BEAT_USE_COUNT)]
public class GC_HEART_BEAT_USE_COUNT_Handler : MessageHandler<GC_HEART_BEAT_USE_COUNT>
{
    protected override void Execute(Robot curRobot, GC_HEART_BEAT_USE_COUNT message)
    {
        
    }
}
