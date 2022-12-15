using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_OPENGIFT_START)]
public class GC_OPENGIFT_START_Handler : MessageHandler<GC_OPENGIFT_START>
{
    protected override void Execute(Robot curRobot, GC_OPENGIFT_START message)
    {
        
    }
}
