using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ACTIVITY_CHANGESTATE)]
public class GC_ACTIVITY_CHANGESTATE_Handler : MessageHandler<GC_ACTIVITY_CHANGESTATE>
{
    protected override void Execute(Robot curRobot, GC_ACTIVITY_CHANGESTATE message)
    {
        
    }
}
