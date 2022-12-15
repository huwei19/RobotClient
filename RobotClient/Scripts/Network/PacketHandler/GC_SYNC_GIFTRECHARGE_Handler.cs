using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_GIFTRECHARGE)]
public class GC_SYNC_GIFTRECHARGE_Handler : MessageHandler<GC_SYNC_GIFTRECHARGE>
{
    protected override void Execute(Robot curRobot, GC_SYNC_GIFTRECHARGE message)
    {
        
    }
}
