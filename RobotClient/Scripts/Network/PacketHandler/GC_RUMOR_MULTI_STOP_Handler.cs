using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RUMOR_MULTI_STOP)]
public class GC_RUMOR_MULTI_STOP_Handler : MessageHandler<GC_RUMOR_MULTI_STOP>
{
    protected override void Execute(Robot curRobot, GC_RUMOR_MULTI_STOP message)
    {
        
    }
}
