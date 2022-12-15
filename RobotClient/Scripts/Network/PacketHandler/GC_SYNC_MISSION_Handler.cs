using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_MISSION)]
public class GC_SYNC_MISSION_Handler : MessageHandler<GC_SYNC_MISSION>
{
    protected override void Execute(Robot curRobot, GC_SYNC_MISSION message)
    {
        
    }
}
