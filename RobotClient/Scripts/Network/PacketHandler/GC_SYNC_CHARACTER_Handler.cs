using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_CHARACTER)]
public class GC_SYNC_CHARACTER_Handler : MessageHandler<GC_SYNC_CHARACTER>
{
    protected override void Execute(Robot curRobot, GC_SYNC_CHARACTER message)
    {
        
    }
}
