using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_CIRCLE)]
public class GC_SYNC_CIRCLE_Handler : MessageHandler<GC_SYNC_CIRCLE>
{
    protected override void Execute(Robot curRobot, GC_SYNC_CIRCLE message)
    {
        
    }
}
