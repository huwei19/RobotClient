using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RUMOR_RESET)]
public class GC_RUMOR_RESET_Handler : MessageHandler<GC_RUMOR_RESET>
{
    protected override void Execute(Robot curRobot, GC_RUMOR_RESET message)
    {
        
    }
}
