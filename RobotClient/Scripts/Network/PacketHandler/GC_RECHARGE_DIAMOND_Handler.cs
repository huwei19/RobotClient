using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RECHARGE_DIAMOND)]
public class GC_RECHARGE_DIAMOND_Handler : MessageHandler<GC_RECHARGE_DIAMOND>
{
    protected override void Execute(Robot curRobot, GC_RECHARGE_DIAMOND message)
    {
        
    }
}
