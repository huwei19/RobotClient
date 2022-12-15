using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_INTERFLOW)]
public class GC_INTERFLOW_Handler : MessageHandler<GC_INTERFLOW>
{
    protected override void Execute(Robot curRobot, GC_INTERFLOW message)
    {
        
    }
}
