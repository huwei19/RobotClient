using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RUMOR_SUB_TIME)]
public class GC_RUMOR_SUB_TIME_Handler : MessageHandler<GC_RUMOR_SUB_TIME>
{
    protected override void Execute(Robot curRobot, GC_RUMOR_SUB_TIME message)
    {
        
    }
}
