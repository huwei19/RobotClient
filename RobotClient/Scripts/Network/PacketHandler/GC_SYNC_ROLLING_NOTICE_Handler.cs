using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_ROLLING_NOTICE)]
public class GC_SYNC_ROLLING_NOTICE_Handler : MessageHandler<GC_SYNC_ROLLING_NOTICE>
{
    protected override void Execute(Robot curRobot, GC_SYNC_ROLLING_NOTICE message)
    {
        
    }
}
