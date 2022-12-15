using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_UPDATE_CIRCLE)]
public class GC_UPDATE_CIRCLE_Handler : MessageHandler<GC_UPDATE_CIRCLE>
{
    protected override void Execute(Robot curRobot, GC_UPDATE_CIRCLE message)
    {
        
    }
}
