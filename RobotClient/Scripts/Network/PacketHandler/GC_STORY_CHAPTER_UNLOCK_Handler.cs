using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_CHAPTER_UNLOCK)]
public class GC_STORY_CHAPTER_UNLOCK_Handler : MessageHandler<GC_STORY_CHAPTER_UNLOCK>
{
    protected override void Execute(Robot curRobot, GC_STORY_CHAPTER_UNLOCK message)
    {
        
    }
}
