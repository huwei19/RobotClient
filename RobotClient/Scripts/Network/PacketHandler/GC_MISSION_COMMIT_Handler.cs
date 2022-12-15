using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MISSION_COMMIT)]
public class GC_MISSION_COMMIT_Handler : MessageHandler<GC_MISSION_COMMIT>
{
    protected override void Execute(Robot curRobot, GC_MISSION_COMMIT message)
    {
        
    }
}
