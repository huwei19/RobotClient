using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CITYWORK_BUBBLE)]
public class GC_CITYWORK_BUBBLE_Handler : MessageHandler<GC_CITYWORK_BUBBLE>
{
    protected override void Execute(Robot curRobot, GC_CITYWORK_BUBBLE message)
    {
        
    }
}
