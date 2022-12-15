using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_SHOPLIST)]
public class GC_SYNC_SHOPLIST_Handler : MessageHandler<GC_SYNC_SHOPLIST>
{
    protected override void Execute(Robot curRobot, GC_SYNC_SHOPLIST message)
    {
        
    }
}
