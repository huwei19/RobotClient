using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MONOLOGUE_UNLOCK)]
public class GC_MONOLOGUE_UNLOCK_Handler : MessageHandler<GC_MONOLOGUE_UNLOCK>
{
    protected override void Execute(Robot curRobot, GC_MONOLOGUE_UNLOCK message)
    {
        
    }
}
