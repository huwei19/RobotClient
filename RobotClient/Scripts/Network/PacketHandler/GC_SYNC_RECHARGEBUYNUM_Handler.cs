using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_RECHARGEBUYNUM)]
public class GC_SYNC_RECHARGEBUYNUM_Handler : MessageHandler<GC_SYNC_RECHARGEBUYNUM>
{
    protected override void Execute(Robot curRobot, GC_SYNC_RECHARGEBUYNUM message)
    {
        
    }
}
