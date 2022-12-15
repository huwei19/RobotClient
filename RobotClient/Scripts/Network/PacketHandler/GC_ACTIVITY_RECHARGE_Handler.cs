using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ACTIVITY_RECHARGE)]
public class GC_ACTIVITY_RECHARGE_Handler : MessageHandler<GC_ACTIVITY_RECHARGE>
{
    protected override void Execute(Robot curRobot, GC_ACTIVITY_RECHARGE message)
    {
        
    }
}
