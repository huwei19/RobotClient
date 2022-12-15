using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MISSION_ACCEPT)]
public class GC_MISSION_ACCEPT_Handler : MessageHandler<GC_MISSION_ACCEPT>
{
    protected override void Execute(Robot curRobot, GC_MISSION_ACCEPT message)
    {
        
    }
}
