using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_GAMECONFIG)]
public class GC_SYNC_GAMECONFIG_Handler : MessageHandler<GC_SYNC_GAMECONFIG>
{
    protected override void Execute(Robot curRobot, GC_SYNC_GAMECONFIG message)
    {
        
    }
}
