using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_HEART_BEAT_FNISH)]
public class GC_HEART_BEAT_FNISH_Handler : MessageHandler<GC_HEART_BEAT_FNISH>
{
    protected override void Execute(Robot curRobot, GC_HEART_BEAT_FNISH message)
    {
        
    }
}
