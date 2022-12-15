using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_NOTICE)]
public class GC_NOTICE_Handler : MessageHandler<GC_NOTICE>
{
    protected override void Execute(Robot curRobot, GC_NOTICE message)
    {
        
    }
}
