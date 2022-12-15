using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PHONE_BINDING)]
public class GC_PHONE_BINDING_Handler : MessageHandler<GC_PHONE_BINDING>
{
    protected override void Execute(Robot curRobot, GC_PHONE_BINDING message)
    {
        
    }
}
