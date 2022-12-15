using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MISSION_DO)]
public class GC_MISSION_DO_Handler : MessageHandler<GC_MISSION_DO>
{
    protected override void Execute(Robot curRobot, GC_MISSION_DO message)
    {
        
    }
}
