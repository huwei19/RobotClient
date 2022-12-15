using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SURVERY)]
public class GC_SURVERY_Handler : MessageHandler<GC_SURVERY>
{
    protected override void Execute(Robot curRobot, GC_SURVERY message)
    {
        
    }
}
