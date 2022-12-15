using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PERSONAL_STORY_UNLOCK)]
public class GC_PERSONAL_STORY_UNLOCK_Handler : MessageHandler<GC_PERSONAL_STORY_UNLOCK>
{
    protected override void Execute(Robot curRobot, GC_PERSONAL_STORY_UNLOCK message)
    {
        
    }
}
