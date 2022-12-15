using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_GUIDE_SAVE)]
public class GC_GUIDE_SAVE_Handler : MessageHandler<GC_GUIDE_SAVE>
{
    protected override void Execute(Robot curRobot, GC_GUIDE_SAVE message)
    {
        
    }
}
