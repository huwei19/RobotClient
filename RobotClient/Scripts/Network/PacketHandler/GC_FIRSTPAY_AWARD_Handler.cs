using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FIRSTPAY_AWARD)]
public class GC_FIRSTPAY_AWARD_Handler : MessageHandler<GC_FIRSTPAY_AWARD>
{
    protected override void Execute(Robot curRobot, GC_FIRSTPAY_AWARD message)
    {
        
    }
}
