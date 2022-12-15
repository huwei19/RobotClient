using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_BATTLEPASSDATA)]
public class GC_SYNC_BATTLEPASSDATA_Handler : MessageHandler<GC_SYNC_BATTLEPASSDATA>
{
    protected override void Execute(Robot curRobot, GC_SYNC_BATTLEPASSDATA message)
    {
        
    }
}
