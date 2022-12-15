using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_SIGNBOARD)]
public class GC_SYNC_SIGNBOARD_Handler : MessageHandler<GC_SYNC_SIGNBOARD>
{
    protected override void Execute(Robot curRobot, GC_SYNC_SIGNBOARD message)
    {
        
    }
}
