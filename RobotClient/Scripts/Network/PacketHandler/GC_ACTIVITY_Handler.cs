using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ACTIVITY)]
public class GC_ACTIVITY_Handler : MessageHandler<GC_ACTIVITY>
{
    protected override void Execute(Robot curRobot, GC_ACTIVITY message)
    {
        
    }
}
