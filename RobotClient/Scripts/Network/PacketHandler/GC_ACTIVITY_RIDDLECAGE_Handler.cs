using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ACTIVITY_RIDDLECAGE)]
public class GC_ACTIVITY_RIDDLECAGE_Handler : MessageHandler<GC_ACTIVITY_RIDDLECAGE>
{
    protected override void Execute(Robot curRobot, GC_ACTIVITY_RIDDLECAGE message)
    {
        
    }
}
