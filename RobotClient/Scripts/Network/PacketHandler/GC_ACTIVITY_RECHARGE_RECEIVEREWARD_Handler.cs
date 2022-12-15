using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ACTIVITY_RECHARGE_RECEIVEREWARD)]
public class GC_ACTIVITY_RECHARGE_RECEIVEREWARD_Handler : MessageHandler<GC_ACTIVITY_RECHARGE_RECEIVEREWARD>
{
    protected override void Execute(Robot curRobot, GC_ACTIVITY_RECHARGE_RECEIVEREWARD message)
    {
        
    }
}
