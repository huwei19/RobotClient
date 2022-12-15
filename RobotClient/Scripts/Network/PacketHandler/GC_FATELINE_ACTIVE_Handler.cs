using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FATELINE_ACTIVE)]
public class GC_FATELINE_ACTIVE_Handler : MessageHandler<GC_FATELINE_ACTIVE>
{
    protected override void Execute(Robot curRobot, GC_FATELINE_ACTIVE message)
    {
        
    }
}
