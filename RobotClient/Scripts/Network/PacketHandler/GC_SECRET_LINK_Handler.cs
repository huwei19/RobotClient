using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SECRET_LINK)]
public class GC_SECRET_LINK_Handler : MessageHandler<GC_SECRET_LINK>
{
    protected override void Execute(Robot curRobot, GC_SECRET_LINK message)
    {
        
    }
}
