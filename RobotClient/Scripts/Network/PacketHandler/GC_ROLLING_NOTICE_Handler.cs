using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ROLLING_NOTICE)]
public class GC_ROLLING_NOTICE_Handler : MessageHandler<GC_ROLLING_NOTICE>
{
    protected override void Execute(Robot curRobot, GC_ROLLING_NOTICE message)
    {
        
    }
}
