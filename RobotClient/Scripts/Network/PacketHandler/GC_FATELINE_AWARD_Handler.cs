using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FATELINE_AWARD)]
public class GC_FATELINE_AWARD_Handler : MessageHandler<GC_FATELINE_AWARD>
{
    protected override void Execute(Robot curRobot, GC_FATELINE_AWARD message)
    {
        
    }
}
