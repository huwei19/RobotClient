using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CIRCLE_REPLY)]
public class GC_CIRCLE_REPLY_Handler : MessageHandler<GC_CIRCLE_REPLY>
{
    protected override void Execute(Robot curRobot, GC_CIRCLE_REPLY message)
    {
        
    }
}
