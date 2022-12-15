using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CIRCLE_CREATE)]
public class GC_CIRCLE_CREATE_Handler : MessageHandler<GC_CIRCLE_CREATE>
{
    protected override void Execute(Robot curRobot, GC_CIRCLE_CREATE message)
    {
        
    }
}
