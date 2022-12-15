using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PERSONAL_STORY_GET_AWARD)]
public class GC_PERSONAL_STORY_GET_AWARD_Handler : MessageHandler<GC_PERSONAL_STORY_GET_AWARD>
{
    protected override void Execute(Robot curRobot, GC_PERSONAL_STORY_GET_AWARD message)
    {
        
    }
}
