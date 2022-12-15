using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_AIBUMLOCK)]
public class GC_SYNC_AIBUMLOCK_Handler : MessageHandler<GC_SYNC_AIBUMLOCK>
{
    protected override void Execute(Robot curRobot, GC_SYNC_AIBUMLOCK message)
    {
        
    }
}
