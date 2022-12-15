using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_SHOP)]
public class GC_SYNC_SHOP_Handler : MessageHandler<GC_SYNC_SHOP>
{
    protected override void Execute(Robot curRobot, GC_SYNC_SHOP message)
    {
        
    }
}
