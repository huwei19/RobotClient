using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_GUIDE_STEP_ID)]
public class GC_GUIDE_STEP_ID_Handler : MessageHandler<GC_GUIDE_STEP_ID>
{
    protected override void Execute(Robot curRobot, GC_GUIDE_STEP_ID message)
    {
        
    }
}
