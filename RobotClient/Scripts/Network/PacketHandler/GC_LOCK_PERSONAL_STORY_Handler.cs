using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_LOCK_PERSONAL_STORY)]
public class GC_LOCK_PERSONAL_STORY_Handler : MessageHandler<GC_LOCK_PERSONAL_STORY>
{
    protected override void Execute(Robot curRobot, GC_LOCK_PERSONAL_STORY message)
    {
        
    }
}
