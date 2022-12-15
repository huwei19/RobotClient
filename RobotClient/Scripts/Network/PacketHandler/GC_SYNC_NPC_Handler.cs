using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_NPC)]
public class GC_SYNC_NPC_Handler : MessageHandler<GC_SYNC_NPC>
{
    protected override void Execute(Robot curRobot, GC_SYNC_NPC message)
    {
        
    }
}
